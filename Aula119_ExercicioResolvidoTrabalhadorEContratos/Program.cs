using System;
using System.Globalization;
using Aula119_ExercicioResolvidoTrabalhadorEContratos.Enteties;
using Aula119_ExercicioResolvidoTrabalhadorEContratos.Enteties.Enums;

namespace Aula119_ExercicioResolvidoTrabalhadorEContratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();
            Console.Write("Enter worker data:\nName: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/MedLevel/Senior: ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double workerSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(departmentName);
            Worker worker = new Worker(workerName, workerLevel, workerSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int numberOfContracts = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfContracts; i++)
            {
                Console.Write($"Enter #{i} contract data:\nDate (DD/MM/YYYY): ");
                DateTime contractDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int contractHours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(contractDate, valuePerHour, contractHours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month)}");
        }
    }
}
