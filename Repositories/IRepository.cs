using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Repositories
{
    public interface IRepository
    {
        public double GetBalance(string creditCardNumber, double creditLimit, double processingCharge);
        
    }

}

