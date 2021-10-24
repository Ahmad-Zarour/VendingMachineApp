using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineApp.Modle;

namespace VendingMachineApp.Data
{
    public class MoneyPool
    {
        static int _balance;
        public  int Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        // check if the data entered is a numeric value or not
        public int Validate(string input)
        {
            int numericValue;
            bool success = int.TryParse(input, out numericValue);
            if (!success)
                return -1;
            else
                return numericValue;
        }

        // Rest the balance to zero after refunding
        public void ResetBalance()
        {
            Balance = 0;
        }

        // pritout the current balance
        public void ShowBalance()
        {
            Console.WriteLine($" [{Balance}]kr");
        }

        // get the balance as a value
        public int GetBalance()
        {
            return Balance;
        }
    }
}
