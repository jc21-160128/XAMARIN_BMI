using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarinbmi
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BmiResult : ContentPage
	{
		public BmiResult ()
		{
			InitializeComponent ();
            buttonBack.Clicked += buttonBackClicked;
		}

        private void buttonBackClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        public BmiResult(float height, int weight)
        {
            InitializeComponent();
            labelBMI.Text = "BMI=" + weight / (height * height);
            buttonBack.Clicked += buttonBackClicked;
        }
	}
}