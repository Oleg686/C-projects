using Org.Apache.Http.Cookies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kyrsach_Diplom
{
    public partial class MainPage : ContentPage
    {
        Entry cre = new Entry();
        Entry ras = new Entry();
    public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            StackLayout layout = new StackLayout();
            Label label1 = new Label();
            label1.Text = "Калькулятор автомобилиста";
            label1.TextColor = Color.Red;
            label1.FontSize = 20;
            label1.FontAttributes = FontAttributes.Bold;
            ras.Placeholder = "Введите расстояние";
            cre.Placeholder = "Средний расход топлива на 100 км";
            btn.Clicked += Btn_Clicked;
            layout.Children.Add(label1);
            layout.Children.Add(ras);
            layout.Children.Add(cre);
            layout.Children.Add(btn);
            Content = layout;
        }
        private void Btn_Clicked(object sender, EventArgs e)
        {
            btn.Text = Convert.ToString(Convert.ToDouble(ras.Text) * Convert.ToDouble(cre.Text) / 100);
        }
    }
}
