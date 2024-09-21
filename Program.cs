using System.Data;
using System.Runtime.Serialization.Formatters;

internal class Program
{
    private static void Main(string[] args)
    {
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
        Midicen m4 = new Midicen("poison ", "die");

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
