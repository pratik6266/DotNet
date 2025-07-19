class Student(string name, int age) : Teacher()
{
  private readonly string? name = name;
  private readonly int? age = age;

  public string GetName()
  {
    return name ?? "Unknown";
  }

  public int GetAge()
  {
    return age ?? 0;
  }
}
