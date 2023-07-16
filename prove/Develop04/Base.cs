public abstract class Activity{
  public int Duration{get; set;}
  public abstract void Perform();
  public void startActivity(){
    Console.WriteLine("Get ready to start...");
    Countdown(3);
    Perform();
  }
  protected void Countdown(int seconds){
    for(int i = seconds; i > 0; i--){
      Console.WriteLine(i);
      Thread.Sleep(3000);
    }
  }

    internal double GetDistance()
    {
        throw new NotImplementedException();
    }

    internal double GetSpeed()
    {
        throw new NotImplementedException();
    }
}