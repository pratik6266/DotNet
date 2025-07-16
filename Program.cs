using System;

class Program
{
  public static void Main()
  {
    Student student = new Student("Pratik Raj", 21);

    Console.WriteLine("Student Name: " + student.getName());
    Console.WriteLine("Student Age: " + student.getAge());
    Console.WriteLine("Teacher Post: " + student.post);
  }
}