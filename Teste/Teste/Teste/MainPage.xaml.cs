using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Teste.Classes;
using System.Net;
using Newtonsoft.Json;

namespace Teste
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            ListView.ItemsSource = new MainPage().Carregar("1103202");

        }

        
        private List<Mensagem> Carregar(String Matricula)
        {

            string EnderecoURL = "http://10.0.1.4:8093/datasnap/rest/TSMAcademico/doConsultaAvisoslApp/" + Matricula;

            WebClient wc = new WebClient();
            NetworkCredential credentials = new NetworkCredential("0", "0");
            wc.Credentials = credentials;

            String Conteudo = wc.DownloadString(EnderecoURL); // metodo sincrono -- trava tela


            return JsonConvert.DeserializeObject<List<Mensagem>>(Conteudo);

        }
    }
}
