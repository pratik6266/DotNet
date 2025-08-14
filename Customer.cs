class Customer : Bank //! implemeting a abastract class do not need to implement all methods
//todo by comma sperate you can implements multiple interfaces
{
  public void CheckBalance() //todo you cannot use override here bacause this is not an abstract class
  {
    Console.WriteLine("Checking balance for customer.");
  }

  public void Credit()
  {
    Console.WriteLine("Credit operation for customer.");
  }

  public void Debit()
  {
    Console.WriteLine("Debit operation for customer.");
  }

  public void Loing()
  {
    Console.WriteLine("Logging in customer.");
  }
}