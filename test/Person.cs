using System.ComponentModel;
using System.Security.Cryptography;

namespace test;

//Available globally
public class Person
{
  //Fields (variables, methods, properties)
  //public string name;
  //public int age;

  //The field PROPERTIES "Name" and "Age" have short-hand getter/setter
  public string Name { get; private set; }
  public int Age { get; private set; }

  //Constructor (intial values for class Person)
  public Person(string name, int age) {
    //Set class field properties(getter/setter fns)
    Name = name;
    Age = age;

    //Set class field variables, traditionally
    // this.name = name;
    // this.age = age;
  }

  //Shorthand for accessors
  // public string Name {
  //   get { return name; }
  //   set { name = value;}
  // }

  // public int Age {
  //   get { return age; }
  //   set { age = value; }
  // }

//Not static method because it is class method, we want to use it throughout the projects scope and not just one file
  public string Greet() {
    return $"Hello, my name is {Name} and I am {Age} yrs old.";
  }

}
