namespace Softuniada2020
{
    using System;

    class Program
    {
        static void Main()
        {
            decimal startingSalary = decimal.Parse(Console.ReadLine());
            decimal monthlyExpense = decimal.Parse(Console.ReadLine());
            decimal salaryUP = decimal.Parse(Console.ReadLine());
            decimal dreamCarMoney = decimal.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());


            decimal earned = 0;
            for (int i = 1; i <= month; i++)
            {
                if (i == 1)
                    startingSalary = startingSalary;
                else
                    startingSalary = startingSalary + salaryUP;

                earned += startingSalary;
            }

            Console.WriteLine(earned);
            decimal expenseTotal = month * monthlyExpense;
            decimal TotalSum = earned - expenseTotal;

            if (TotalSum >= dreamCarMoney)
                Console.WriteLine("Have a nice ride!");
            else
                Console.WriteLine("Work harder!");

        }
    }
}
