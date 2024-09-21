public class Doctor : Person
{

    public Doctor(string name, int age, bool gender, string speclization, string DoctorId) : base(name, age, gender)
    {
        this.speclization = speclization;
        this.DoctorId = DoctorId;
    }
    string speclization;
    string DoctorId;
    List<Apointment> apointments = new List<Apointment>();



}