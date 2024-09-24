public class Apointment
{
   public Apointment(string DoctorId, string PatiantId, string apointemntDate)
   {
      this.DoctorId = DoctorId;
      this.PatiantId = PatiantId;
      this.apointemntDate = apointemntDate;
   }
   string apointemntDate;
   string DoctorId;
   string PatiantId;
   public void apointemntInfo()
   {
      Console.WriteLine("apointemntDate : " + apointemntDate + "/n" + "DoctorId : " + DoctorId + "\n" + " PatiantId : " + PatiantId);
   }
}