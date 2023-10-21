using System;
using System.Collections.Generic;
using System.Numerics;

namespace ClinicApp
{
    internal class Program
    {
        static List<Doctor> doctors = new List<Doctor>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Clinic Management System");
            bool isAdmin = Login();

            while (isAdmin)
            {
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1. View Doctors");
                if (isAdmin)
                {
                    Console.WriteLine("2. Add Doctor");
                    Console.WriteLine("3. Modify Doctor Phone");
                    Console.WriteLine("4. Modify Doctor Experience");
                    Console.WriteLine("5. Delete Doctor");
                }
                Console.WriteLine("6. Exit");

                if(int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch(choice)
                    {
                        case 1:
                            ViewDoctors();
                            break;
                        case 2:
                            if (isAdmin)
                                AddDoctor();
                            else
                                Console.WriteLine("Access Denied. You are not an admin.");
                            break;
                        case 3:
                            if (isAdmin) 
                                ModifyDoctorPhone();
                            else
                                Console.WriteLine("Access Denied. You are not an admin.");
                            break;
                        case 4:
                            if (isAdmin)
                                ModifyDoctorExperience();
                            else
                                Console.WriteLine("Access denied. You are not an admin.");
                            break;
                        case 5:
                            if (isAdmin)
                                DeleteDoctor();
                            else
                                Console.WriteLine("Access denied. You are not an admin.");
                            break;
                        case 6:
                            Console.WriteLine("Goodbye!");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        static bool Login()
        {
            Console.WriteLine("Are you an Admin? (Y/N)");
            string input = Console.ReadLine();
            return input.Equals("Y", StringComparison.OrdinalIgnoreCase);
        }

        static void ViewDoctors()
        {
            Console.WriteLine("List of Doctors:");
            foreach(Doctor doctor in doctors)
            {
                Console.WriteLine($"Doctor ID: {doctor.Id}");
                Console.WriteLine($"Doctor Name: {doctor.Name}");
                Console.WriteLine($"Phone: {doctor.Phone}");
                Console.WriteLine($"Experience: {doctor.Experience} years");
                Console.WriteLine();
            }
        }

        static void AddDoctor()
        {
            Console.Write("Enter Doctor Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Doctor Phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter Doctor Experience (in years): ");
            if (int.TryParse(Console.ReadLine(), out int experience))
            {
                Doctor doctor = new Doctor(name, phone, experience);
                doctors.Add(doctor);
                Console.WriteLine("Doctor added successfully!");
            }
            else
            {
                Console.WriteLine("Invalid input for experience. Please enter a number.");
            }
        }

        static void ModifyDoctorPhone()
        {
            Console.Write("Enter the Doctor's ID you want to modify: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Doctor doctor = doctors.Find(d => d.Id == id);
                if (doctor != null)
                {
                    Console.Write("Enter new phone number: ");
                    doctor.Phone = Console.ReadLine();
                    Console.WriteLine("Phone number modified successfully.");
                }
                else
                {
                    Console.WriteLine("Doctor not found with the given ID.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for ID. Please enter a number.");
            }
        }
        static void ModifyDoctorExperience()
        {
            Console.Write("Enter the Doctor's ID you want to modify: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Doctor doctor = doctors.Find(d => d.Id == id);
                if (doctor != null)
                {
                    Console.Write("Enter new experience (in years): ");
                    if (int.TryParse(Console.ReadLine(), out int experience))
                    {
                        doctor.Experience = experience;
                        Console.WriteLine("Experience modified successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for experience. Please enter a number.");
                    }
                }
                else
                {
                    Console.WriteLine("Doctor not found with the given ID.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for ID. Please enter a number.");
            }
        }
        static void DeleteDoctor()
        {
            Console.Write("Enter the Doctor's ID you want to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Doctor doctor = doctors.Find(d => d.Id == id);
                if (doctor != null)
                {
                    doctors.Remove(doctor);
                    Console.WriteLine("Doctor deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Doctor not found with the given ID.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for ID. Please enter a number.");
            }
        }
    }

    class Doctor
    {
        private static int nextId = 1;

        public int Id { get; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Experience { get; set; }

        public Doctor(string name, string phone, int experience)
        {
            Id = nextId++;
            Name = name;
            Phone = phone;
            Experience = experience;
        }
    }

}