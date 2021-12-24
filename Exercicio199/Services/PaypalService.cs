using System;
using System.Collections.Generic;

namespace Exercicio199.Services
{
    class PaypalService : IFinancingService
    {
        private double Fees = 1;
        private double Tax = 2;
        public double[] Installments(double amount, int numberInstallments)
        {
            double[] installments = new double[numberInstallments];
            for(int i = 0; i < numberInstallments; i++)
            {
                double baseInstallment = amount / numberInstallments;
                double calcFees = baseInstallment * (100 + ( (i + 1)  * Fees)) / 100;
                double calcTax = calcFees * (100 + Tax) / 100;

                installments[i] = calcTax;
            }
            return installments;
        }
    }
}
