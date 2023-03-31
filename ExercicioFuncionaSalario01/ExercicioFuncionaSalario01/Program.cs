using System;
using System.Globalization;

namespace ExercicioFuncionaSalario01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int countEmployee = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i=0; i < countEmployee; i++) {

                Console.WriteLine("*************************************************");
                Console.WriteLine("Emplyoee #"+i+":");
                Console.WriteLine("Informe o id do funcionario");
                int idEmp = int.Parse(Console.ReadLine());
                
                Console.WriteLine("*************************************************");
                
                Console.WriteLine("Informe o nome do funcionario");
                string nameEmp = Console.ReadLine();
                
                Console.WriteLine("*************************************************");
                
                Console.WriteLine("Informe o salario do funcionario");
                double salaryEmp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                list.Add(new Employee(idEmp, nameEmp, salaryEmp));
            }

            Console.WriteLine("Enter the employee id that will have salary increase :");
            int idUpdateEmp = int.Parse(Console.ReadLine());
            Employee emp = list.Find(e => e.Id == idUpdateEmp);


            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percent);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            foreach (var item in list)
            {
                Console.WriteLine("Updated list of employees:");
                Console.WriteLine("Id: " + item.Id + ", Nome: " + item.Name + ", Salario: " + item.Salary);
            }
        }
    }
}