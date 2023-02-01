using JM_ExamenProgreso3.JM_Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ExamenProgreso3.JM_Data
{
    public class JM_ExamenDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;

        public JM_ExamenDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }

        private void Init()
        {
            if (conn != null) return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<JM_Perro>();
        }

        public int AddNewDog(JM_Perro perro)
        {
            Init();

            if (perro.JM_id != 0)
            {
                return conn.Update(perro);
            }
            else
            {
                return conn.Insert(perro);
            }
        }

        public List<JM_Perro> GetAllDogs()
        {
            Init();
            List<JM_Perro> perritos = conn.Table<JM_Perro>().ToList();
            return perritos;
        }

        public int DeleteDog(JM_Perro perro)
        {
            Init();
            return conn.Delete(perro);
        }

    }
}
