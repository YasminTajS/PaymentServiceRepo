using PaymentService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Repositories
{
    public class PaymentRepository : IRepository
    {
        //public List<ProcessPayment> products;

        public PaymentRepository()
        {

        }

        public double GetBalance(string creditCardNumber, double creditLimit, double processingCharge)
        {
            double balance = 0;
            if (processingCharge <= creditLimit)
            {
                balance += creditLimit - processingCharge;
                return balance;
            }
            else
                return -1;

        }


    }
}
