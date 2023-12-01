using System.Globalization;
using System.Net.Http.Json;
using System.Text;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Divorce_Prediction
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }


        private async void button_Start_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Questions());
            //string array = "[[3, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 1, 1, 1, 0, 3, 3, 2, 2, 0, 2, 2, 0, 0, 4]]";
            //double rate = await SVC.GetResult(array);
            //button_Start.Text = rate.ToString() + "%";
        }

    }
}