using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getri_FirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();

            employee1.EmpId = 1;
            employee1.EmpName = "Getri";
            employee1.EmpAddress = "Kathmandu";
            employee1.EmpSal = 10000;

            employee2.EmpId = 2;
            employee2.EmpName = "Raj";
            employee2.EmpAddress = "Delhi";
            employee2.EmpSal = 20000;

            employee3.EmpId = 3;
            employee3.EmpName = "Rahul";
            employee3.EmpAddress = "Mumbai";
            employee3.EmpSal = 30000;

            Console.WriteLine("Employee Details");
            Console.WriteLine($"Employee Id: {employee1.EmpId} - Employee Name: {employee1.EmpName} - Employee Address: {employee1.EmpAddress} - Employee Salary: {employee1.EmpSal}");
            Console.WriteLine($"Employee Id: {employee2.EmpId} - Employee Name: {employee2.EmpName} - Employee Address: {employee2.EmpAddress} - Employee Salary: {employee2.EmpSal}");
            Console.WriteLine($"Employee Id: {employee3.EmpId} - Employee Name: {employee3.EmpName} - Employee Address: {employee3.EmpAddress} - Employee Salary: {employee3.EmpSal}");

            Arithmetic objAddArithmetic = new Arithmetic();
            int addResult = objAddArithmetic.Add(10, 20);

            Arithmetic objSubArithmetic = new Arithmetic();
            int subResult = objSubArithmetic.Sub(20, 10);

            Arithmetic objMulArithmetic = new Arithmetic();
            int mulResult = objMulArithmetic.Mul(10, 20);

            Arithmetic objDivArithmetic = new Arithmetic();
            int divResult = objDivArithmetic.Div(20, 10);

            Console.WriteLine($"Addition Result: {addResult}");
            Console.WriteLine($"Subtraction Result: {subResult}");
            Console.WriteLine($"Multiplication Result: {mulResult}");
            Console.WriteLine($"Division Result: {divResult}");

            Console.ReadLine();
        }
    }

    public class Employee
    {         
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAddress { get; set; }
        public float EmpSal { get; set; }        
    }
}
