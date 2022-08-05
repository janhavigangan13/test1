using System;
using LitwareLib;


namespace EmployeeManagementSystem
{

	public class Employee
	{

		private int EmpNo;
		private string EmpName;
		public double Salary;
		private double HRA;
		private double TA;
		private double DA;
		private double PF;
		private double TDS;
		private double NetSalary;
		public double GrossSalary;

		public static void Main()
		{
			Employee emp = new Employee();
			emp.empdetail();
			emp.CalculateNetPay();
			emp.CalculateSalary();
			emp.Display();
		}
		public void empdetail()
		{
			Console.WriteLine("enter the employee number");
			EmpNo = int.Parse(Console.ReadLine());

			Console.WriteLine("enter the employee name");
			EmpName = Console.ReadLine();

			Console.WriteLine("enter the employee salary");
			Salary = double.Parse(Console.ReadLine());

		}

		public void CalculateNetPay()
		{
			HRA = 10 * Salary / 100;
			DA = 15 * Salary / 100;
			GrossSalary = Salary + HRA + DA;
			TA = 2 * Salary / 100;
		}

		public void CalculateSalary()
		{
			PF = 10 * GrossSalary / 100;
			TDS = 18 * GrossSalary / 100;
			NetSalary = GrossSalary - (PF - TDS);

		}

		public void Display()
		{
			CalculateNetPay();
			CalculateSalary();

			Console.WriteLine($"Employee Number: {EmpNo}\nEmployee Name: {EmpName}\nSalary: {Salary}\nHRA:{HRA} " +
				$"\nDA:{DA}\nTAX: {TA}\nGrossSalary: {GrossSalary}\nPF: {PF}\nTDS: {TDS}\nNetSalary: {NetSalary}");
		}

	}
}