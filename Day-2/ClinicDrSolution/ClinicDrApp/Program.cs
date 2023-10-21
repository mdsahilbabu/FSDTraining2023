using System;
using System.Collections.Generic;

namespace ClinicDrApp
{
    class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Experience { get; set; }
    }

    class Clinic
    {
        private List<Doctor> doctors = new List<Doctor>();
        private int nextDoctorId = 1;

        public void AddDoctor(string name, string phone, string experience)
        {
            doctors.Add(new Doctor
            {
                Id = nextDoctorId,
                Name = name,
                Phone = phone,
                Experience = experience
            });
            nextDoctorId++;
        }

        public Doctor FindDoctorById(int doctorId)
        {
            return doctors.Find(d => d.Id == doctorId);
        }

        public void ModifyDoctorPhone(int doctorId, string newPhone)
        {
            var doctor = FindDoctorById(doctorId);
            if (doctor != null)
            {
                doctor.Phone = newPhone;
            }
        }

        public void ModifyDoctorExperience(int doctorId, string newExperience)
        {
            var doctor = FindDoctorById(doctorId);
            if (doctor != null)
            {
                doctor.Experience = newExperience;
            }
        }

        public void DeleteDoctor(int doctorId)
        {
            var doctor = FindDoctorById(doctorId);
            if (doctor != null)
            {
                doctors.Remove(doctor);
            }
        }

        public void UpdateDoctor(int doctorId, string name, string phone, string experience)
        {
            var doctor = FindDoctorById(doctorId);
            if (doctor != null)
            {
                doctor.Name = name;
                doctor.Phone = phone;
                doctor.Experience = experience;
            }
        }

        public List<Doctor> GetDoctors()
        {
            return doctors;
        }
    }

    class Program
    {
        static Clinic clinic = new Clinic();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Clinic Application.");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AdminMenu();
                        break;
                    case "2":
                        UserMenu();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("Admin Menu");
                Console.WriteLine("1. View Doctor List");
                Console.WriteLine("2. Add Doctor");
                Console.WriteLine("3. Modify Doctor Phone");
                Console.WriteLine("4. Modify Doctor Experience");
                Console.WriteLine("5. Delete Doctor");
                Console.WriteLine("6. Update Doctor");
                Console.WriteLine("7. Back");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewDoctorList();
                        break;
                    case "2":
                        AddDoctor();
                        break;
                    case "3":
                        ModifyDoctorPhone();
                        break;
                    case "4":
                        ModifyDoctorExperience();
                        break;
                    case "5":
                        DeleteDoctor();
                        break;
                    case "6":
                        UpdateDoctor();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ViewDoctorList()
        {
            var doctors = clinic.GetDoctors();
            if (doctors.Count == 0)
            {
                Console.WriteLine("No doctors found.");
            }
            else
            {
                Console.WriteLine("Doctor List:");
                foreach (var doctor in doctors)
                {
                    Console.WriteLine($"ID: {doctor.Id}, Name: {doctor.Name}, Phone: {doctor.Phone}, Experience: {doctor.Experience}");
                }
            }
        }

        static void AddDoctor()
        {
            Console.WriteLine("Enter Doctor Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Doctor Phone:");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter Doctor Experience:");
            string experience = Console.ReadLine();
            clinic.AddDoctor(name, phone, experience);
            Console.WriteLine("Doctor added successfully.");
        }

        static void ModifyDoctorPhone()
        {
            Console.WriteLine("Enter Doctor ID to modify phone:");
            if (int.TryParse(Console.ReadLine(), out int doctorId))
            {
                Console.WriteLine("Enter new phone number:");
                string newPhone = Console.ReadLine();
                clinic.ModifyDoctorPhone(doctorId, newPhone);
                Console.WriteLine("Doctor phone modified successfully.");
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid ID.");
            }
        }

        static void ModifyDoctorExperience()
        {
            Console.WriteLine("Enter Doctor ID to modify experience:");
            if (int.TryParse(Console.ReadLine(), out int doctorId))
            {
                Console.WriteLine("Enter new experience:");
                string newExperience = Console.ReadLine();
                clinic.ModifyDoctorExperience(doctorId, newExperience);
                Console.WriteLine("Doctor experience modified successfully.");
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid ID.");
            }
        }

        static void DeleteDoctor()
        {
            Console.WriteLine("Enter Doctor ID to delete:");
            if (int.TryParse(Console.ReadLine(), out int doctorId))
            {
                clinic.DeleteDoctor(doctorId);
                Console.WriteLine("Doctor deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid ID.");
            }
        }

        static void UpdateDoctor()
        {
            Console.WriteLine("Enter Doctor ID to update:");
            if (int.TryParse(Console.ReadLine(), out int doctorId))
            {
                Console.WriteLine("Enter new Doctor Name:");
                string updatedName = Console.ReadLine();
                Console.WriteLine("Enter new Doctor Phone:");
                string updatedPhone = Console.ReadLine();
                Console.WriteLine("Enter new Doctor Experience:");
                string updatedExperience = Console.ReadLine();
                clinic.UpdateDoctor(doctorId, updatedName, updatedPhone, updatedExperience);
                Console.WriteLine("Doctor updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid ID.");
            }
        }

        static void UserMenu()
        {
            Console.WriteLine("User Menu");
            Console.WriteLine("1. View Doctor List");
            Console.WriteLine("2. Back");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewDoctorList();
                    break;
                case "2":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

}