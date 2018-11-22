using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarinbmi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ButtonBMI.Clicked += ButtonBmiClickEvent;
            ButtonBMI2.Clicked += ButtonBmiClickEvent2;
        }

        private void ButtonBmiClickEvent2(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            float height = float.Parse(EntryHeight.Text);
            if(height > 3)
            {
                height = height / 100;
            }
            int weight = int.Parse(EntryWeight.Text);
            Navigation.PushModalAsync(new NavigationPage(new BmiResult(height, weight)));
        }

        private void ButtonBmiClickEvent(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            float height = float.Parse(EntryHeight.Text);
            if(height > 3)
            {
                height = height / 100;
            }
            height = height * height;
            int weight = int.Parse(EntryWeight.Text);
            float bmi = weight / height;
            LabelResult.Text = "" + bmi;
        }
    }
}
