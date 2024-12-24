public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Designation { get; set; }
    public string Specialization { get; set; }

    // Navigation property for the related appointments
    public ICollection<Appointment> Appointments { get; set; }
}
