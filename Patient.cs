using System.Diagnostics;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

public class Patiant : Person
{

  public Patiant(string name, int age, bool gender, string patiantId) : base(name, age, gender) // pass the parameter to constrector in base class
  {
    this.patiantId = patiantId;
  }
  string patiantId;
  public List<Disease> midicalHistory { get; } = new List<Disease>();
  public List<Apointment> apointment { get; } = new List<Apointment>();
  private void dispalyMidicalHistory()
  {
    Console.WriteLine("Midical Hestory : ");
    foreach (var dis in midicalHistory)
    {
      dis.diseaseInfo();
    }

  }

  public override void GetInfo()
  {

    Console.WriteLine("person name is " + name + "\n" + "person age is " +
 age + "\n" + "person gender is " + (gender ? "male" : "female") + "\n");

    dispalyMidicalHistory();
  }
}

public class Disease
{

  public Disease(string name)
  {
    this.name = name;
  }
  string name;

  public List<Midicen> midicens { get; } = new List<Midicen>();

  public void diseaseInfo()
  {

    Console.WriteLine("name : " + name + "\n the midicens : \n");
    for (int i = 0; i < midicens.Count; i++)
    {
      Console.WriteLine(i + "- midicen name : " + midicens[i].getname() + " midicen sideeffects : " + midicens[i].getsideeffects());
    }
  }

}
public class Midicen
{
  public Midicen(string name, string sideeffects)
  {
    this.name = name;
    this.sideeffects = sideeffects;
  }
  public string name { get; set; }
  public string sideeffects { set; get; }

  public string getname() { return name; }
  public void setname(string name) { this.name = name; }

  public string getsideeffects() { return sideeffects; }
  public void setsideeffects(string sideeffects) { this.sideeffects = sideeffects; }

}