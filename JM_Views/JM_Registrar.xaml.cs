using JM_ExamenProgreso3.JM_Models;
using static JM_ExamenProgreso3.JM_Api.JM_ClaseApi;
using System.Net;
using Newtonsoft.Json;

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
        Item.JM_CreationDate = DateTime.Parse(cosoFecha.Text);
        App.ExamenDatabase.AddNewDog(Item);
        Shell.Current.GoToAsync("..");
    }

    public void cargarDatosApi()
    {
        WebRequest request = WebRequest.Create("https://dog-breeds2.p.rapidapi.com/dog_breeds");
        request.Headers.Add("'X-RapidAPI-Key': 121532ef24msh46a3a1d2d48d563p161c94jsndb12bb45a2dd");
        request.Headers.Add("'X-RapidAPI-Key': 121532ef24msh46a3a1d2d48d563p161c94jsndb12bb45a2dd");
        WebResponse response = request.GetResponse();
        var client = new HttpClient(); using (Stream dataStream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            responseFromServer = responseFromServer.Trim();             
            var resultado = JsonConvert.DeserializeObject<Root>(responseFromServer);
        }

        response.Close();
    }
}