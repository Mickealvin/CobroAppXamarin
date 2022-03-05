using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cobro
{
    public partial class MainPage : ContentPage
    {

        double montoFactura;
        double dias;
        double descuento;
        double mora;
        double netoApagar;
        double totalApagar;
        public MainPage()
        {
            
            InitializeComponent();
            
        }

        public void Entradas()
        {
            montoFactura = Convert.ToDouble(EmontoFactura.Text);
            dias = Convert.ToDouble(EDias.Text);
        }

        public void Decision(object sender, EventArgs e)
        {
            Entradas();

            if (dias <= 30)
            {
                descuento = montoFactura * 0.10;
                netoApagar = montoFactura - descuento;
            }
            else
            {
                mora = montoFactura * 0.05;
                totalApagar = montoFactura + mora;
            }
            {
                Salidas(sender, e);
            }
        }

        public void Salidas(object sender, EventArgs e)
        {
            EmontoFactura.Text = Convert.ToString(montoFactura);
            EDias.Text = Convert.ToString(dias);
            EDescuento.Text = Convert.ToString(descuento);
            EMora.Text = Convert.ToString(mora);
            ENetoapagar.Text = Convert.ToString(netoApagar);
            ETotalapagar.Text=Convert.ToString(totalApagar);
        }

        public void Limpiar(object sender, EventArgs e)
        {
            montoFactura = 0;
            dias = 0;
            descuento = 0;
            mora = 0;
            netoApagar = 0;
            totalApagar = 0;
            EmontoFactura.Text = "0";
            EDias.Text = "0";
            EMora.Text = "0";
            EDescuento.Text = "0";
            ENetoapagar.Text = "0";
            ETotalapagar.Text = "0";
        }
    }
}
