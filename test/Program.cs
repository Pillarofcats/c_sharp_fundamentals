// using System;
// using System.ComponentModel.DataAnnotations;
// using System.Security.Cryptography.X509Certificates;

using test; //namespace/bring in Console and other things

class Program
{

  //loaded into memory once, starting location of application
  static void Main()
  {
    //Logger
    PrintText();
    //Variables
    DataTypes();
    //Type casting
    TypeCasting();
    //Arrays
    Arrays();
    //Methods
    Methods();
    //Collections
    Collections();
    //Queue
    AQueue();
    //Stack
    AStack();
    //Private method
    PrivateMethod();
    //Classes
    AClass();
    //Exception handling
    ExceptionHandling();
    //Inheritance + CustomException class
    CustomExceptionInheritance();

  }

  static void PrintText()
  {
    Console.WriteLine("test");
  }

  static void DataTypes()
  {

    string name = "Jacob";
    int num = 1;
    char a = 'a';
    byte b = 255;
    bool c = true;
    double d = 1000000000;
    float e = 1.0000001f; //trailing f
    decimal f = .0000001m; //trailing m

    Console.WriteLine($"Variables: string={name}, int={num}, char={a}, byte={b}, bool={c} double={d}, float={e}, decimal={f}");
  }

  static void TypeCasting()
  {
    string str = "c";
    char strToChar = Convert.ToChar(str);

    Console.WriteLine($"Casting: str to byte={strToChar}");
  }

  static void Arrays()
  {
    int[] fixedArr = new int[3];
    fixedArr[0] = 1;
    fixedArr[1] = 2;
    fixedArr[2] = 3;
    int[] dynamicArr = new int[] { 1, 2, 3, 4, 5 };

    foreach (int elem in fixedArr)
    {
      Console.WriteLine($"dynamic arr: [{elem}]");
    }
    for (int i = 0; i < dynamicArr.Length; i++)
    {
      Console.WriteLine($"fixed arr: [{i}]={dynamicArr[i]}");
    }
  }

  static void Methods()
  {

    static void printText(string str)
    {
      Console.WriteLine($"Printing text: {str}");
    }

    static string returnText(string str)
    {
      return str;
    }

    printText("Print method text!");
    Console.WriteLine(returnText("Returned method text!"));
  }

  static void Collections()
  {
    //Array (static) (allows duplicates)
    string[] names = new string[5];
    names = ["Bayleigh", "Michael", "Jacob", "Dan", "Erik"];

    foreach (string name in names)
    {
      Console.WriteLine($"Array ele: {name}");
    }
    Console.WriteLine($"Array Length {names.Length}");

    //List (dynamic) (allows duplicates)
    List<string> cities = new List<string>();
    cities = ["Belton", "Raymore", "Peculiar"];
    cities.Remove("Belton");
    cities.Add("Rolla");

    foreach (string city in cities)
    {
      Console.WriteLine($"List ele: {city}");
    }
    Console.WriteLine($"List Count: {cities.Count}");

    //Hashset (dynamic) (NO duplicates)
    HashSet<string> countries = new HashSet<string>();
    countries = ["US", "Canada"];
    countries.Add("US"); //Won't be inserted, duplicate

    foreach (string country in countries)
    {
      Console.WriteLine($"HashSet ele: {country}");
    }
    Console.WriteLine($"HashSet Count: {countries.Count}");

    //Dictionary, (it is a map object, unique keys with possible duplicate values)
    Dictionary<char, int> letterGrades = new Dictionary<char, int>();
    letterGrades.Add('A', 90);
    letterGrades.Add('B', 80);
    letterGrades.Add('C', 70);
    letterGrades.Add('D', 60);
    letterGrades['F'] = 50;

    foreach (var letter in letterGrades)
    {
      Console.WriteLine($"Dictionary ele: Key:{letter.Key} Value:{letter.Value}");
    }
    Console.WriteLine($"Dictionary Count: {letterGrades.Count}");

  }

  static void AQueue() {
    //First in first out
    Queue<string> Q = new Queue<string>();
    //Add to Queue
    Q.Enqueue("Q first");
    Q.Enqueue("Q second");
    Q.Enqueue("Q third");
    //Remove from Queue
    Q.Dequeue();

    foreach(string item in Q) {
      Console.WriteLine($"Queue item: {item}");
    }
  }

  static void AStack(){
    //Last in first out
    Stack<string> TheStack = new Stack<string>();
    //Push to top
    TheStack.Push("Stack first");
    TheStack.Push("Stack second");
    TheStack.Push("Stack third");
    //Pop top
    TheStack.Pop();

    foreach(string item in TheStack) {
      Console.WriteLine($"Stack item: {item}");
    }
  }

  //Within same file.class so it can be called
  private static void PrivateMethod() {
    Console.WriteLine("This is a private method");
  }

  static void AClass() {
    //Create new person
    Person jacob = new Person("Jacob", 34);
    Console.WriteLine($"Creating a person class: {jacob.Name}");
    Console.WriteLine( jacob.Greet() );
  }

  static void ExceptionHandling() {
    int a = 1;
    int b = 0;

    try {
      int notZero = a / b;
    } catch(Exception exc) {
      Console.WriteLine("Error: " + exc.Message);
    } finally {
      Console.WriteLine("Post Error: Remaining code has been run.");
    }
  }

  static void CustomExceptionInheritance() {
    Boolean student = false;

    try {
      Console.WriteLine("Is person a student? (false)");
      if(student) {
        
      } else {
        throw new CustomException("You must be a student to access lectures.");
      }
    } catch (CustomException exc) {
        Console.WriteLine("Custom Error: " + exc.Message);
    }
  }

};