using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Initialize DbContext
        var optionsBuilder = new DbContextOptionsBuilder<AppointmentContext>();
        optionsBuilder.UseSqlServer("Server=DESKTOP-H92GP94\\SQLEXPRESS02;Database=AppointmentDB;Trusted_Connection=True;MultipleActiveResultSets=true");

        using (var context = new AppointmentContext(optionsBuilder.Options))
        {
            // LINQ query to fetch appointments with doctor and patient details
            var appointments = from a in context.Appointments
                               join p in context.Patients on a.PatientId equals p.Id
                               join d in context.Doctors on a.DoctorId equals d.Id
                               select new
                               {
                                   AppointmentId = a.Id,
                                   PatientName = p.Name,
                                   DoctorName = d.Name,
                                   AppointmentDate = a.AppointmentDate,
                                   AppointmentTime = a.AppointmentTime
                               };

            // Display results
            if (appointments.Any())
            {
                foreach (var appointment in appointments)
                {
                    Console.WriteLine($"Appointment ID: {appointment.AppointmentId}, " +
                                      $"Patient: {appointment.PatientName}, " +
                                      $"Doctor: {appointment.DoctorName}, " +
                                      $"Date: {appointment.AppointmentDate.ToShortDateString()}, " +
                                      $"Time: {appointment.AppointmentTime}");
                }
            }
            else
            {
                Console.WriteLine("No appointments found.");
            }

        }
    }
}
