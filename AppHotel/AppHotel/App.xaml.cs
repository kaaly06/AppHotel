using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.Generic;

using System.Threading;
using System.Globalization;

using AppHotel.Model;
using AppHotel.View;


namespace AppHotel
{
    public partial class App : Application
    {
        public List<Suite> lista_suites = new List<Suite>
        {
            new Suite()
            {
               Descricao = "Padrão Alto",
               DiariaAdulto = 320.0,
               DiariaCrianca = 160.0
            },
            new Suite()
            {
               Descricao = "Intermediário",
               DiariaAdulto = 200.0,
               DiariaCrianca = 100.0
            },
            new Suite()
            {
               Descricao = "Padrão Baixo",
               DiariaAdulto = 100.0,
               DiariaCrianca = 50.0
            }
        };

        public App()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            InitializeComponent();
            MainPage = new NavigationPage(new ContratacaoHospedagem());
        }

        protected override void OnStart()
        {
         
        }
        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
