using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project_Calculator
{
    public partial class MainPage : ContentPage
    {
        public string Result;
        public int operation;
        public double a;
        public bool colormode;
        public double v;
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            input.BackgroundColor = Color.FromHex("222A68");
            input.TextColor = Color.FromHex("AB81CD");

            res.BackgroundColor = Color.FromHex("222A68");
            res.TextColor = Color.FromHex("AB81CD");

            BtnAdd.BackgroundColor = Color.FromHex("222A68");
            BtnAdd.TextColor = Color.FromHex("AB81CD");

            BtnSub.BackgroundColor = Color.FromHex("222A68");
            BtnSub.TextColor = Color.FromHex("AB81CD");

            BtnMul.BackgroundColor = Color.FromHex("222A68");
            BtnMul.TextColor = Color.FromHex("AB81CD");

            BtnDiv.BackgroundColor = Color.FromHex("222A68");
            BtnDiv.TextColor = Color.FromHex("AB81CD");

            BtnEqu.BackgroundColor = Color.FromHex("222A68");
            BtnEqu.TextColor = Color.FromHex("AB81CD");

            BtnC.BackgroundColor = Color.FromHex("222A68");
            BtnC.TextColor = Color.FromHex("AB81CD");

            Btn0.BackgroundColor = Color.FromHex("222A68");
            Btn0.TextColor = Color.FromHex("AB81CD");

            Btn1.BackgroundColor = Color.FromHex("222A68");
            Btn1.TextColor = Color.FromHex("AB81CD");

            Btn2.BackgroundColor = Color.FromHex("222A68");
            Btn2.TextColor = Color.FromHex("AB81CD");

            Btn3.BackgroundColor = Color.FromHex("222A68");
            Btn3.TextColor = Color.FromHex("AB81CD");

            Btn4.BackgroundColor = Color.FromHex("222A68");
            Btn4.TextColor = Color.FromHex("AB81CD");

            Btn5.BackgroundColor = Color.FromHex("222A68");
            Btn5.TextColor = Color.FromHex("AB81CD");

            Btn6.BackgroundColor = Color.FromHex("222A68");
            Btn6.TextColor = Color.FromHex("AB81CD");

            Btn7.BackgroundColor = Color.FromHex("222A68");
            Btn7.TextColor = Color.FromHex("AB81CD");

            Btn8.BackgroundColor = Color.FromHex("222A68");
            Btn8.TextColor = Color.FromHex("AB81CD");

            Btn8.BackgroundColor = Color.FromHex("222A68");
            Btn8.TextColor = Color.FromHex("AB81CD");

            Btn9.BackgroundColor = Color.FromHex("222A68");
            Btn9.TextColor = Color.FromHex("AB81CD");

            BtnDot.BackgroundColor = Color.FromHex("222A68");
            BtnDot.TextColor = Color.FromHex("AB81CD");

            Btnlig.BackgroundColor = Color.FromHex("222A68");
            Btnlig.TextColor = Color.FromHex("AB81CD");
            Btnlig.Text = "Light Mode";

            Application.Current.MainPage.BackgroundColor = Color.FromHex("463B35");

            colormode = false;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue)) return;

            if (!double.TryParse(e.NewTextValue, out double value))
            {
                ((Entry)sender).Text = e.OldTextValue;
            }
        }

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            if (Double.TryParse(input.Text,out v))
            {
                res.Text = String.Empty;
                operation = 0;
                a = 0;
                a = Double.Parse(input.Text);
                res.Text = a + " + ";
                operation = 1;
                input.Text = String.Empty;
            }
            else
            {
                res.Text = "error";
                input.Text = String.Empty;
            }
        }
        private void BtnSub_Clicked(object sender, EventArgs e)
        {
            if (Double.TryParse(input.Text, out v))
            {
                res.Text = String.Empty;
                operation = 0;
                a = 0;
                a = Double.Parse(input.Text);
                res.Text = a + " - ";
                operation = 2;
                input.Text = String.Empty;
            }
            else
            {
                res.Text = "error";
                input.Text = String.Empty;
            }
        }
        private void BtnMul_Clicked(object sender, EventArgs e)
        {
            if (Double.TryParse(input.Text, out v))
            {
                res.Text = String.Empty;
                operation = 0;
                a = 0;
                a = Double.Parse(input.Text);
                res.Text = a + " * ";
                operation = 3;
                input.Text = String.Empty;
            }
            else
            {
                res.Text = "error";
                input.Text = String.Empty;
            }
        }
        private void BtnDiv_Clicked(object sender, EventArgs e)
        {
            if (Double.TryParse(input.Text, out v))
            {
                res.Text = String.Empty;
                operation = 0;
                a = 0;
                a = Double.Parse(input.Text);
                res.Text = a + " / ";
                operation = 4;
                input.Text = String.Empty;
            }
            else
            {
                res.Text = "error";
                input.Text = String.Empty;
            }
        }
        private void BtnEqu_Clicked(object sender, EventArgs e)
        {

            if (Double.TryParse(input.Text, out v))
            {
                double b = Double.Parse(input.Text);
                switch (operation)
                {
                    case 1:
                        Result = (a + b).ToString();
                        res.Text = res.Text + (b).ToString();
                        break;
                    case 2:
                        Result = (a - b).ToString();
                        res.Text = res.Text + (b).ToString();
                        break;
                    case 3:
                        Result = (a * b).ToString();
                        res.Text = res.Text + (b).ToString();
                        break;
                    case 4:
                        Result = (a / b).ToString();
                        res.Text = res.Text + (b).ToString();
                        break;
                    default:
                        break;
                }
                res.Text = res.Text + " = " + Result;
                input.Text = String.Empty;
                Result = String.Empty;
                operation = 0;
                a = 0;
            }
            else
            {
                res.Text = "error";
                input.Text = String.Empty;
            }
        }
        private void BtnC_Clicked(object sender, EventArgs e)
        {
            input.Text = String.Empty;
            res.Text = String.Empty;
            operation = 0;
            Result = String.Empty;
            a = 0;
        }
        private void Btnlig_Clicked(object sender, EventArgs e)
        {
            if (colormode == false)
            {
                input.BackgroundColor = Color.FromHex("AB81CD");
                input.TextColor = Color.FromHex("222A68");

                res.BackgroundColor = Color.FromHex("AB81CD");
                res.TextColor = Color.FromHex("222A68");

                BtnAdd.BackgroundColor = Color.FromHex("AB81CD");
                BtnAdd.TextColor = Color.FromHex("222A68");

                BtnSub.BackgroundColor = Color.FromHex("AB81CD");
                BtnSub.TextColor = Color.FromHex("222A68");

                BtnMul.BackgroundColor = Color.FromHex("AB81CD");
                BtnMul.TextColor = Color.FromHex("222A68");

                BtnDiv.BackgroundColor = Color.FromHex("AB81CD");
                BtnDiv.TextColor = Color.FromHex("222A68");

                BtnEqu.BackgroundColor = Color.FromHex("AB81CD");
                BtnEqu.TextColor = Color.FromHex("222A68");

                BtnC.BackgroundColor = Color.FromHex("AB81CD");
                BtnC.TextColor = Color.FromHex("222A68");

                Btn0.BackgroundColor = Color.FromHex("AB81CD");
                Btn0.TextColor = Color.FromHex("222A68");

                Btn1.BackgroundColor = Color.FromHex("AB81CD");
                Btn1.TextColor = Color.FromHex("222A68");

                Btn2.BackgroundColor = Color.FromHex("AB81CD");
                Btn2.TextColor = Color.FromHex("222A68");

                Btn3.BackgroundColor = Color.FromHex("AB81CD");
                Btn3.TextColor = Color.FromHex("222A68");

                Btn4.BackgroundColor = Color.FromHex("AB81CD");
                Btn4.TextColor = Color.FromHex("222A68");

                Btn5.BackgroundColor = Color.FromHex("AB81CD");
                Btn5.TextColor = Color.FromHex("222A68");

                Btn6.BackgroundColor = Color.FromHex("AB81CD");
                Btn6.TextColor = Color.FromHex("222A68");

                Btn7.BackgroundColor = Color.FromHex("AB81CD");
                Btn7.TextColor = Color.FromHex("222A68");

                Btn8.BackgroundColor = Color.FromHex("AB81CD");
                Btn8.TextColor = Color.FromHex("222A68");

                Btn8.BackgroundColor = Color.FromHex("AB81CD");
                Btn8.TextColor = Color.FromHex("222A68");

                Btn9.BackgroundColor = Color.FromHex("AB81CD");
                Btn9.TextColor = Color.FromHex("222A68");

                BtnDot.BackgroundColor = Color.FromHex("AB81CD");
                BtnDot.TextColor = Color.FromHex("222A68");

                Btnlig.BackgroundColor = Color.FromHex("AB81CD");
                Btnlig.TextColor = Color.FromHex("222A68");
                Btnlig.Text = "Dark Mode";

                Application.Current.MainPage.BackgroundColor = Color.FromHex("60935D");

                colormode = true;
            }
            else
            {
                input.BackgroundColor = Color.FromHex("222A68");
                input.TextColor = Color.FromHex("AB81CD");

                res.BackgroundColor = Color.FromHex("222A68");
                res.TextColor = Color.FromHex("AB81CD");

                BtnAdd.BackgroundColor = Color.FromHex("222A68");
                BtnAdd.TextColor = Color.FromHex("AB81CD");

                BtnSub.BackgroundColor = Color.FromHex("222A68");
                BtnSub.TextColor = Color.FromHex("AB81CD");

                BtnMul.BackgroundColor = Color.FromHex("222A68");
                BtnMul.TextColor = Color.FromHex("AB81CD");

                BtnDiv.BackgroundColor = Color.FromHex("222A68");
                BtnDiv.TextColor = Color.FromHex("AB81CD");

                BtnEqu.BackgroundColor = Color.FromHex("222A68");
                BtnEqu.TextColor = Color.FromHex("AB81CD");

                BtnC.BackgroundColor = Color.FromHex("222A68");
                BtnC.TextColor = Color.FromHex("AB81CD");


                Btn0.BackgroundColor = Color.FromHex("222A68");
                Btn0.TextColor = Color.FromHex("AB81CD");

                Btn1.BackgroundColor = Color.FromHex("222A68");
                Btn1.TextColor = Color.FromHex("AB81CD");

                Btn2.BackgroundColor = Color.FromHex("222A68");
                Btn2.TextColor = Color.FromHex("AB81CD");

                Btn3.BackgroundColor = Color.FromHex("222A68");
                Btn3.TextColor = Color.FromHex("AB81CD");

                Btn4.BackgroundColor = Color.FromHex("222A68");
                Btn4.TextColor = Color.FromHex("AB81CD");

                Btn5.BackgroundColor = Color.FromHex("222A68");
                Btn5.TextColor = Color.FromHex("AB81CD");

                Btn6.BackgroundColor = Color.FromHex("222A68");
                Btn6.TextColor = Color.FromHex("AB81CD");

                Btn7.BackgroundColor = Color.FromHex("222A68");
                Btn7.TextColor = Color.FromHex("AB81CD");

                Btn8.BackgroundColor = Color.FromHex("222A68");
                Btn8.TextColor = Color.FromHex("AB81CD");

                Btn8.BackgroundColor = Color.FromHex("222A68");
                Btn8.TextColor = Color.FromHex("AB81CD");

                Btn9.BackgroundColor = Color.FromHex("222A68");
                Btn9.TextColor = Color.FromHex("AB81CD");

                BtnDot.BackgroundColor = Color.FromHex("222A68");
                BtnDot.TextColor = Color.FromHex("AB81CD");

                Btnlig.BackgroundColor = Color.FromHex("222A68");
                Btnlig.TextColor = Color.FromHex("AB81CD");
                Btnlig.Text = "Light Mode";

                Application.Current.MainPage.BackgroundColor = Color.FromHex("463B35");

                colormode = false;
            }
        }
        // nummpad button controls
        private void Btn0_Clicked(object sender, EventArgs e)
        {
            input.Text = input.Text + "0";
        }
        private void Btn1_Clicked(object sender, EventArgs e)
        {
            input.Text = input.Text + "1";
        }
        private void Btn2_Clicked(object sender, EventArgs e)
        {
            input.Text = input.Text + "2";
        }
        private void Btn3_Clicked(object sender, EventArgs e)
        {
            input.Text = input.Text + "3";
        }
        private void Btn4_Clicked(object sender, EventArgs e)
        {
            input.Text = input.Text + "4";
        }
        private void Btn5_Clicked(object sender, EventArgs e)
        {
            input.Text = input.Text + "5";
        }
        private void Btn6_Clicked(object sender, EventArgs e)
        {
            input.Text = input.Text + "6";
        }
        private void Btn7_Clicked(object sender, EventArgs e)
        {
            input.Text = input.Text + "7";
        }
        private void Btn8_Clicked(object sender, EventArgs e)
        {
            input.Text = input.Text + "8";
        }
        private void Btn9_Clicked(object sender, EventArgs e)
        {
            input.Text = input.Text + "9";
        }
        private void BtnDot_Clicked(object sender, EventArgs e)
        {
            input.Text = input.Text + ".";
        }
    }
}
