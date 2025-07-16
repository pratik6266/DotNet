class Student: Teacher
{
  private string? name;
  private int? age;

  public Student(string name, int age) : base()
  {
    this.name = name;
    this.age = age;
  }

  public string getName()
  {
    return name ?? "Unknown";
  }

  public int getAge()
  {
    return age ?? 0;
  }
} 