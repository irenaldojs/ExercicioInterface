using System;
using Exercicio199.Entities;

namespace Exercicio199.Services
{
    class PaymentService
    {
        private IFinancingService _financingService;
        public PaymentService(IFinancingService financingService)
        {
            _financingService = financingService;
        }
        public void ProcessInstallment(Contract contract, int numberInstallmens)
        {
            double[] aux = _financingService.Installments(contract.TotalValue, numberInstallmens);
            Installment[] installments = new Installment[numberInstallmens];
            for(int i = 1; i <= numberInstallmens; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                installments[i - 1] = new Installment(dueDate, aux[i - 1]);
            }
            contract.SetInstallments(installments);
        }
    }
}
