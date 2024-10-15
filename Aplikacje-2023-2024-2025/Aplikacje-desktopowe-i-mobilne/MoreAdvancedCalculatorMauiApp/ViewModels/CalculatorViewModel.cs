using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAdvancedCalculatorMauiApp.ViewModels
{
	public class CalculatorViewModel : BindableObject
	{
		private int calculationResault;

		public int CalculationResault
		{
			get { return calculationResault; }
			set { calculationResault = value; OnPropertyChanged(); }
		}

		private Command numericCommand;

		public Command NumericCommand
		{
			get
			{
				if (numericCommand == null)
					numericCommand = new Command<string>((string strNumber) =>
					{
						int digit = int.Parse(strNumber);
						CalculationResault = CalculationResault * 10;

					});
				return numericCommand;
			}
		}
	}
}
