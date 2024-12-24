public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactInfo { get; set; }

    // Navigation property for the related appointments
    public ICollection<Appointment> Appointments { get; set; }
}
