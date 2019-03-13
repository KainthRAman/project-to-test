﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_to_test
{
   
         /// <summary>
        /// Bank Account demo class 
       /// </summary>
        public class BankAccount
        {
            private string m_customerName;
            private double m_balance;
            private bool m_frozen = false;
            private BankAccount()
            {

            }
            public BankAccount(String customerName, double balance)
            {
                m_customerName = customerName;
                m_balance = balance;
            }
        }
    }

