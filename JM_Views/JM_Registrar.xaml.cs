using JM_ExamenProgreso3.JM_Models;

namespace JM_ExamenProgreso3.JM_Views;

[QueryProperty("Item", "Item")]
public partial class JM_Registrar : ContentPage
{
    public JM_Perro Item
    {
        get => BindingContext as JM_Perro;
        set => BindingContext = value;
    }
    public JM_Registrar()
	{
		InitializeComponent();
	}

    private void JM_CrearPerroClicked(object sender, EventArgs e)
    {
        Item.CreationDate = DateTime.Parse(fuente.Text);
        App.ExamenRepo.AddNewDog(Item);
        Shell.Current.GoToAsync("..");
    }

    public void cargarDatosApi()
    {

    }
}