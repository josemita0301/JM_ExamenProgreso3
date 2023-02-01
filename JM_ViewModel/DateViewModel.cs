using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JM_ExamenProgreso3.JM_ViewModel
{
    internal class DateViewModel : INotifyPropertyChanged
    {
        DateTime JM_dateTime;
        Timer _timer;

        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime DateTime
        {
            get => JM_dateTime;
            set
            {
                if (JM_dateTime != value)
                {
                    JM_dateTime = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateViewModel()
        {
            this.DateTime = DateTime.Now;
            _timer = new Timer(new TimerCallback((s) => this.DateTime = DateTime.Now), null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }

        ~DateViewModel() => _timer.Dispose();

        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }
}
