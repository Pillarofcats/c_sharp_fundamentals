namespace test;

//Inherit Exception base class (super/parent)
public class CustomException : Exception
{
  public CustomException() {}
  //Custom exception, pass argument "msg" to base Exception class
  public CustomException(string msg) : base(msg) {}
}
