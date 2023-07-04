using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace TipCalculator
{
    public class TipModel: INotifyPropertyChanged
    {
		private decimal totalPerPerson;
		private decimal totalTip;
		private decimal totalBill;
		private decimal tipPerPerson;

		public decimal Total { get; set; }
        public int PercentageTip { get; set; }
        public int NumberPeople { get; set; }
		public decimal TotalTip
		{
			get { return totalTip; }
			set
			{
				totalTip = value;
				OnPropertyChanged();
			}
		}
		public decimal TotalBill
		{
			get { return totalBill; }
			set
			{
				totalBill = value;
				OnPropertyChanged();
			}
		}
		public decimal TipPerPerson
		{
			get { return tipPerPerson; }
			set
			{
				tipPerPerson = value;
				OnPropertyChanged();
			}
		}
		public decimal TotalPerPerson
		{
			get { return totalPerPerson;}
			set {
				totalPerPerson = value;
				OnPropertyChanged();
			}
		}


		public Command OperationsCommand { get; set; }

        public TipModel()
        {
            OperationsCommand = new Command(Operations);
		}

		private void Operations()
        {
			TotalTip = Total * ((decimal)PercentageTip / 100);
			TotalBill = Total + TotalTip;
			TipPerPerson = TotalTip / NumberPeople;
			TotalPerPerson = TotalBill / NumberPeople;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs((propertyName)));
		}
	}
}
