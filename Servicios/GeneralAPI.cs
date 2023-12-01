using MovilApp.IServicios;

namespace MovilApp.Servicios
{

    public class GeneralAPI : IGeneralAPI
    {

        //static readonly string direccionbase = "http://10.0.2.2:5000"; // cuando use el emulador
        static readonly string direccionbase = "http://10.18.2.86:5000"; //IP de cada maquina cuando use dispositivo local
        static readonly string _url = $"{direccionbase}/api/";

        public  HttpClient GetHttpClient()
        {
          
           var client = new HttpClient();
           client.DefaultRequestHeaders.Add("Accept", "application/json");

            return client;

        }

        public string URL(string controller)
        {
            return _url  + controller + "/" ;
        }
    }
}
