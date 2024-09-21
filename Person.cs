using System.Dynamic;

public class Person
{
  public Person(String name, int age, bool gender)
  {
    this.name = name;
    this.age = age;
    this.gender = gender;
  }
  public Person()
  {
    this.age = 0;
    this.name = "not added yet";
    this.gender = true;
  }
  protected String name;
  protected int age;
  protected bool gender; // true means male and false means female hhhhhhhh 

  public virtual void GetInfo()
  {
    Console.WriteLine("person name is " + name + "\n" + "person age is " +
     age + "\n" + "person gender is " + (gender ? "male" : "female") + "\n");
  }
}