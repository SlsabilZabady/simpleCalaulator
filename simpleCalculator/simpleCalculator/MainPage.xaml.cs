using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace simpleCalculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        String Operation = "";
        Double first, second;
        public MainPage()
        {
            InitializeComponent();
        }

        private void operation_Clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            first = Double.Parse(Txtdisplay.Text);
            Operation = b.Text;
            Txtdisplay.Text = "";
        }

        private void clear_Clicked(object sender, EventArgs e)
        {
            Txtdisplay.Text = "0";
        }

        private void btnResult_Clicked(object sender, EventArgs e)
        {
            second = Double.Parse(Txtdisplay.Text);
            switch (Operation)
            {
                case "+":
                    Txtdisplay.Text = Convert.ToString(first + second);
                    break;
                case "-":
                    Txtdisplay.Text = Convert.ToString(first - second);
                    break;
                case "X":
                    Txtdisplay.Text = Convert.ToString(first * second);
                    break;
                case "div":
                    Txtdisplay.Text = Convert.ToString(first / second);
                    break;
                default:
                    break;
            }
        }

        private void btnPM_Clicked(object sender, EventArgs e)
        {
            if(Txtdisplay.Text.Contains("-"))
            {
                Txtdisplay.Text = Txtdisplay.Text.Remove(0,1);
            }
            else 
            {
                Txtdisplay.Text = "-" + Txtdisplay.Text;
            }
        }

        private void btnMod_Clicked(object sender, EventArgs e)
        {
            first = Convert.ToDouble(Txtdisplay.Text) / Convert.ToDouble(100);
            Txtdisplay.Text = System.Convert.ToString(first);
        }

        private void btn7_Clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Txtdisplay.Text == "0")
                Txtdisplay.Text = "";

            if(b.Text == ".")
            {
                if (!Txtdisplay.Text.Contains("."))

                    Txtdisplay.Text = Txtdisplay.Text + b.Text;
            }
            else
            {
                Txtdisplay.Text = Txtdisplay.Text + b.Text;
            }
        }
    }
}
