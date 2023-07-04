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
		private TipModel tipModel;

		public MainPage()
		{
			InitializeComponent();

			tipModel = new TipModel
			{
				PercentageTip = 5,
				NumberPeople = 2,
			};

			this.BindingContext = tipModel;
		}
	}
}
