namespace Physical;

public class Sample {
  public int    time;
  public double value;
  
  public Sample (int time, double value) {
    this.time  = time;
    this.value = value;
  }
  
    public int GetTime()
    {
        return time;
    }
    public double GetValue()
    {
        return value;
    }


  public override string ToString () {
    return "sample("+time+"→"+value+")";
  }
}
