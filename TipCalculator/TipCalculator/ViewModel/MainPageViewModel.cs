using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TipCalculator.ViewModel
{
    public class MainPageViewModel
    {
		public Command OperationsCommand { get; set; }
        public TipModel model { get; set; }

        public MainPageViewModel()
        {
			model = new TipModel
			{
				PercentageTip = 5,
				NumberPeople = 2,
			};
			OperationsCommand = new Command(Operations);
		}

		private void Operations()
		{
			model.TotalTip = model.Total * ((decimal)model.PercentageTip / 100);
			model.TotalBill = model.Total + model.TotalTip;
			model.TipPerPerson = model.TotalTip / model.NumberPeople;
			model.TotalPerPerson = model.TotalBill / model.NumberPeople;
		}
	}
}
