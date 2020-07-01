using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace myPrimerApp
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnMostrar_Clicked(object sender, EventArgs e)
        {
            if(txtNom.Text != null)
            {
                lblRes.Text = "Bienvenido/a  Sr/a :" + txtNom.Text;
                txtNom.Text="";
            }
            else
            {
                DisplayAlert("Alerta", "Favor Introducir un Nombre Antes de Pulsar el Boton", "OK");
            }
        }
    }
}
