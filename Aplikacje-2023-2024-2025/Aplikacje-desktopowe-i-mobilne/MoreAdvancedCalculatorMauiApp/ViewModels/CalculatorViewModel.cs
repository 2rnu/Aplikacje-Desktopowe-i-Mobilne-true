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

        private Command? numericCommand;
        public Command NumericCommand
		{
			get
			{
				if (numericCommand == null)
					numericCommand = new Command<string>(strNumber =>
					{
						int digit = int.Parse(strNumber);

                        if (isOperationAction )
                        {
                            CalculationResault = CalculationResault * 10 + digit;
                        }
                        else
                        {
							prevValue = calculationResault;
							calculationResault = digit;
							isOperationAction = false;
                        }

                    });
				return numericCommand;
			}
		}

        private Command? operationCommand;
        public Command OperationCommand
        {
            get
            {
                if (operationCommand == null)
                    operationCommand = new Command<string>(operationSign=>
                    {
						CalculationResault = Calculate(prevValue, CalculationResault, prevOperationSign);
						prevOperationSign = operationSign;
                        isOperationAction = true;
                    });
				return operationCommand;
            }
        }

        private int Calculate(int firstValue, int secondValue, string operationSign)
        {
			int value = 0;
			
			switch (operationSign)
			{
				case "+":
					value = firstValue + secondValue; break;
				case "-":
					value = firstValue - secondValue; break;
				case "*":
					value = firstValue * secondValue; break;
				case "/":
					value = firstValue / secondValue; break;
			}
			return value;
        }

		public string? prevOperationSign = "*";
		public int prevValue = 1;
		private bool isOperationAction = false;
    }
}


















