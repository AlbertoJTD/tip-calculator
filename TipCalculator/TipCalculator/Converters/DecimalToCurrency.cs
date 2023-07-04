using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace TipCalculator.Converters
{
	class DecimalToCurrency : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var newValue = (decimal)value;
			return newValue.ToString("C");
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string valor = (string)value;
			return valor.Remove(0);
		}
	}
}
