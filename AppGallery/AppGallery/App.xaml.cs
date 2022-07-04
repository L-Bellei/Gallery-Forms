using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var pagina = new NavigationPage(
            //   new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01()
            //);

            //var pagina = new CarouselPage();
            //pagina.Children.Add(new XamarinForms.Paginas.Carrossel.Conteudo01());
            //pagina.Children.Add(new XamarinForms.Paginas.Carrossel.Conteudo02());
            //pagina.Children.Add(new XamarinForms.Paginas.Carrossel.Conteudo03());

            //MainPage = new XamarinForms.Paginas.Carrossel.Carrossel();

            //var pagina = new MasterDetailPage();
            ////Menu
            //pagina.Master = ;
            ////Conteudo
            //pagina.Detail = ;

            MainPage = new XamarinForms.Paginas.PaginasMenuLateral.MenuLateral();
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
