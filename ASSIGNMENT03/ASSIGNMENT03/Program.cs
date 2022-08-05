using System;
using LitwareLib;




interface Iprintable
{
	void Print();
} 

namespace EmployeeManagementSystem
{

	public class Program
	{
        public static void Main()
        {
            try
            {
                Console.WriteLine("enter no.of employee");
                int size = Convert.ToInt32(Console.ReadLine());
                Employee[] obj1 = new Employee[size];
                Employee obj = new Employee();

                Console.WriteLine("----------Accepting Employee Details----------");

                for (int i = 0; i < obj1.Length; i++)
                {
                    Console.WriteLine("Enter Employee Number:");
                    int no = int.Parse(Console.ReadLine());
                    obj.setempno(no);

                    Console.WriteLine("Enter Employee Name:");
                    string name = Console.ReadLine();
                    obj.setempname(name);

                    Console.WriteLine("Enter Employee Salary:");
                    double salary = double.Parse(Console.ReadLine());
                    obj.setEmpSalary(salary);
                    obj.sethra();
                    obj.setta();
                    obj.setda();
                    obj.setgs();
                    obj.calculatesalary();
                }
                Console.WriteLine("----------displaying Employee Details----------");
                for (int i = 0; i < obj1.Length; i++)
                {
                    obj.getEmpNo();
                    obj.getEmpName();
                    obj.getEmpSalary();
                    obj.getgs();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
            }




            try
            {
                Console.WriteLine("enter no.of employee");
                int size = Convert.ToInt32(Console.ReadLine());
                Manager[] obj1 = new Manager[size];
                Manager mobj = new Manager();

                Console.WriteLine("----------Accepting Manager Details----------");

                for (int i = 0; i < obj1.Length; i++)
                {
                    Console.WriteLine("Enter Manager Number:");
                    int no = int.Parse(Console.ReadLine());
                    mobj.setempno(no);

                    Console.WriteLine("Enter Manager Name:");
                    string name = Console.ReadLine();
                    mobj.setempname(name);

                    Console.WriteLine("Enter Manager Salary:");
                    double salary = double.Parse(Console.ReadLine());
                    mobj.setEmpSalary(salary);
                    mobj.setpa();
                    mobj.setfa();
                    mobj.setoa();
                    mobj.setgrsl();
                    mobj.calculatesalary();

                }
                Console.WriteLine("----------displaying Manager Details----------");
                for (int i = 0; i < obj1.Length; i++)
                {
                    mobj.getEmpNo();
                    mobj.getEmpName();
                    mobj.getEmpSalary();
                    mobj.getgrsl();
                    mobj.getcalsal();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
            }






            try
            {
                Console.WriteLine("enter no.of employee");
                int size = Convert.ToInt32(Console.ReadLine());
                MarketingExecutive[] obj1 = new MarketingExecutive[size];
                MarketingExecutive meobj = new MarketingExecutive();

                Console.WriteLine("----------Accepting Manager Details----------");

                for (int i = 0; i < obj1.Length; i++)
                {
                    Console.WriteLine("Enter MarketingExecutive Number:");
                    int no = int.Parse(Console.ReadLine());
                    meobj.setempno(no);

                    Console.WriteLine("Enter MarketingExecutive Name:");
                    string name = Console.ReadLine();
                    meobj.setempname(name);

                    Console.WriteLine("Enter MarketingExecutive Salary:");
                    double salary = double.Parse(Console.ReadLine());
                    meobj.setEmpSalary(salary);
                    meobj.setta();
                    meobj.settela();
                    meobj.setgrsl();
                    meobj.calculatesalary();

                }
                Console.WriteLine("----------displaying Manager Details----------");
                for (int i = 0; i < obj1.Length; i++)
                {
                    meobj.getEmpNo();
                    meobj.getEmpName();
                    meobj.getEmpSalary();
                    meobj.getgrsl();
                    meobj.getcalsal();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
            }

        }
    }
}