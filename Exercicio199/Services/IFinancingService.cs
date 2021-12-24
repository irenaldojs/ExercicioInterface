using System.Collections.Generic;
namespace Exercicio199.Services
{
    interface IFinancingService
    {
        double[] Installments(double amount, int numberInstallments);
    }
}
