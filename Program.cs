using System.Data;
using System.Runtime.Serialization.Formatters;

internal class Program
{
    public void addapointement(string DoctorName, string PatiantName, string Date, List<Patiant> p1, List<Doctor> d1)
    {
        Doctor doc = null;
        Patiant pat = null;
        foreach (var k in p1)
        {
            if (PatiantName == k.name)
            {
                pat = k;
                break;
            }
        }

        foreach (var k in d1)
        {
            if (DoctorName == k.name)
            {
                doc = k;
            }
        }
        if (doc == null || pat == null)
        {
            Console.WriteLine("somthing is missing maybe wrong name ! ");
        }
        Apointment ap = new Apointment(doc.DoctorId, pat.patiantId, Date);
        doc.apointments.Add(ap);
        pat.apointment.Add(ap);
    }

    // Try itrator method : create an itrator method
    static IEnumerable<int> getEvenNumbers(int[] a)
    {
        foreach (int x in a)
        {
            if (x % 2 == 0) yield return x;
        }
    }

    private static void Main(string[] args)
    {
        // use itrator method 
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        foreach (int x in getEvenNumbers(a))
        {
            Console.WriteLine(x);
        }

        // Try Lambda 
        var sumOf2numbers = (int a, int b) => a + b;
        Console.WriteLine(sumOf2numbers(1, 2));

        // or  ,, here we used the lambda as a function that do some operation and return a value 
        var andplsor = (int a, int b) =>
        {
            int x = a & b;
            int y = a | b;
            return x + y;
        };
        Console.WriteLine(andplsor(1, 2));

        // Try Anonymous Types :
        // to declare any thing anonymosly like an tembrory object  
        var anything = new
        {
            name = "ameen",
            moreanonymous = new { speed = 55, anotherone = "code" }

        };
        Console.WriteLine(anything.moreanonymous.speed);

        // try indexer : 
        // make an Object be useed as an array and access to things by indexes choosen by you see in aopintment class 
        Apointment ap1 = new Apointment("", "", "");
        ap1[0] = "kk";
        ap1[1] = "dd";
        ap1[2] = "23";

        // start of the project 
        List<Patiant> p1 = new List<Patiant>();
        List<Doctor> d1 = new List<Doctor>();
        // add new patiant 
        p1.Add(new Patiant("Ahmad", 25, true, "1"));
        p1.Add(new Patiant("Ameen", 23, true, "2"));
        p1.Add(new Patiant("Rawan", 30, false, "3"));

        // add new doctors 

        d1.Add(new Doctor("Ali", 33, true, "heart", "111"));
        d1.Add(new Doctor("samar", 42, false, "heart", "222"));
        d1.Add(new Doctor("omar", 37, true, "heart", "333"));

        // create  midicen 

        Midicen m1 = new Midicen("acamole", "sleep");
        Midicen m2 = new Midicen("unacamole", "wokup");
        Midicen m3 = new Midicen("felmora", "feel disapointed");
        Midicen m4 = new Midicen("nopain ", "nogain");

        // create diseases and add midicen to every disease

        Disease ds1 = new Disease("pain");
        ds1.midicens.Add(m1);
        ds1.midicens.Add(m2);

        Disease ds2 = new Disease("PHD");
        ds2.midicens.Add(m2);
        ds2.midicens.Add(m3);

        Disease ds3 = new Disease("CMD");
        ds3.midicens.Add(m3);
        ds3.midicens.Add(m4);

        // now add disease to patiant 

        p1[0].midicalHistory.Add(ds1);
        p1[0].midicalHistory.Add(ds2);
        p1[1].midicalHistory.Add(ds2);
        p1[1].midicalHistory.Add(ds3);
        p1[2].midicalHistory.Add(ds3);

        foreach (var mh in p1)
        {
            mh.GetInfo();
        }

    }
}
