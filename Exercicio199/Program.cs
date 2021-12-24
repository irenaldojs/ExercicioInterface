using System;
using System.Globalization;
using Exercicio199.Entities;
using Exercicio199.Services;

namespace Exercicio199
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Contract contract = new Contract(number, date, contractValue);
            // ----------------- //
            PaymentService paymentService = new(new PaypalService());
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());
            paymentService.ProcessInstallment(contract, installments);
            Console.WriteLine(contract.ToString());

        }
    }
}
