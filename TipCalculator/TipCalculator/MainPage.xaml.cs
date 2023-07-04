using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TipCalculator
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void CalculateButton_Clicked(object sender, EventArgs e)
		{
			var total = (decimal.Parse(inputTotal.Text));
			var tip = (decimal.Parse(inputPercentageTip.Text));
			var numberPeople = (decimal.Parse(inputNumberPeople.Text));

			var totalTip = total * (tip / 100);

			labelTip.Detail = totalTip.ToString("C");
			labelTotal.Detail = (total + totalTip).ToString("C");
			labelTipPerPerson.Detail = (totalTip / numberPeople).ToString("C");
			labelTotalPerPerson.Detail = ((total + totalTip) / numberPeople).ToString("C");
		}
	}
}
