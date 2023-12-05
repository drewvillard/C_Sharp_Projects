using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Part2
{
    class PiggyBank
    {
        public event EventHandler<BalanceArgs> negBalanceChanged;
        private decimal m_bankBalance;
        // Declaring a public event called balancedChanged which is referd to it
        // using the delegate BalanceEventHandler
        // This is considered as an action listener referd to it using
        // the delegate BalanceEventHandler
        public event BalanceEventHandler balanceChanged;

        // public getter and setter for the private member variable m_bankBalance property
        public decimal theBalance
        {
            set // Once setting the value of the balance then trigger the 
                // event balanceChanged to update the new bank account balance
            {
                m_bankBalance = value; //value is the received argument from the place where we
                                       // pass this value (PSVM)
                                       //if the value is less than 0 we call negbalance changed and ask the user for more deposits through
                                       //negbalancechanged
                if (m_bankBalance < 0)
                {
                    BalanceArgs args = new BalanceArgs();
                    args.balance = value;
                    balanceChanged(value);
                    negBalanceChanged(this, args);

                }
                else
                {
                    balanceChanged(value);// Any new value posted (being set), trigger the event.
                }
            }
            get
            {
                return m_bankBalance;
            }
        }
    }
}
