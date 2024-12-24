using Microsoft.EntityFrameworkCore;

public class AppointmentContext : DbContext
{
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

    public AppointmentContext(DbContextOptions<AppointmentContext> options) : base(options) { }

    // Add a parameterless constructor for design-time services
    public AppointmentContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-H92GP94\\SQLEXPRESS02;Database=AppointmentDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }
    }

}
