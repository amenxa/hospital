public class Doctor : Person
{

    public Doctor(string name, int age, bool gender, string speclization, string DoctorId) : base(name, age, gender)
    {
        Console.WriteLine("we are in Doctor constructor ");
        this.speclization = speclization;
        this.DoctorId = DoctorId;
    }
    public string speclization { get; set; }
    public string DoctorId { get; set; }
    public List<Apointment> apointments { get; } = new List<Apointment>();



}