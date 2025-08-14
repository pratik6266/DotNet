using System;

class Program
{
  public static void Main()
  {
    // Student student = new Student("Pratik Raj", 21);
    // Console.WriteLine("Student Name: " + student.GetName());
    // Console.WriteLine("Student Age: " + student.GetAge());
    // Console.WriteLine("Teacher Post: " + student.GetPost());

    Bank customer = new Customer();
    customer.Loing();
    customer.CheckBalance();
    customer.Credit();
    customer.Debit();
  }
}