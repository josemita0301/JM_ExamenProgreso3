using JM_ExamenProgreso3.JM_Models;

namespace JM_ExamenProgreso3.JM_Views;

public partial class JM_PáginaPrincipal : ContentPage
{
	public JM_PáginaPrincipal()
	{
		InitializeComponent();
	}

    private void LoadData()
    {
        List<JM_Perro> JM_perros = App.JM_ExamenDatabase.GetAllDogs();
        perros.ItemsSource = JM_perros;
    }


    private void JM_CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
    private void JM_OnItemAdded(object sender, EventArgs e)
    {

    }

    private void JM_Modificar_Clicked(object sender, EventArgs e)
    {

    }

    private void JM_Borrar_Clicked(object sender, EventArgs e)
    {

    }
}