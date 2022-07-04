using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.PaginasMenuLateral
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuLateral : MasterDetailPage
    {
        public MenuLateral()
        {
            InitializeComponent();
        }

        private void AbrirPag01(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo01());
            IsPresented = false;
        }

        private void AbrirPag02(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo02());
            IsPresented = false;
        }

        private void AbrirPag03(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo03());
            IsPresented = false;
        }
    }
}