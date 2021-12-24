using System;
using System.Text;
using Exercicio199.Services;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicio199.Entities
{
    class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; private set; }
        public double TotalValue { get; private set; }
        public Installment[] Installment { get; private set; }

        public Contract(int number, DateTime dueDate, double totalValue)
        {
            Number = number;
            Date = dueDate;
            TotalValue = totalValue;
            Installment = null;
        }
        public void SetInstallments(Installment[] installment)
        {
            Installment = installment;
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine("Isntallments:");
            for(int i = 0; i < Installment.Length; i++)
            {
                sb.AppendLine(""
                    + Installment[i].DueDate.Date.ToString("d")
                    + " - "
                    + Installment[i].Amount.ToString("F2", CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }

    }
}
