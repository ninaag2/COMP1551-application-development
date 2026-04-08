using System;
using System.Collections.Generic;
using System.Text;

namespace coursework
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Role { get; set; } 

        public Person(int id, string name, string tel, string email, string role)
        {
            Id = id; Name = name; Telephone = tel; Email = email; Role = role;
        }

        public virtual string GetDetails() => $"Name: {Name}, Role: {Role}";
    }

   
    public class Teacher : Person
    {
        public double Salary { get; set; } 
        public string Subject1 { get; set; } 
        public string Subject2 { get; set; }
        public Teacher(int id, string n, string t, string e, double s, string s1, string s2)
            : base(id, n, t, e, "Teaching Staff") { Salary = s; Subject1 = s1; Subject2 = s2; }
        public override string GetDetails()
        {
            return $"[Teacher] {Name} - Salary: {Salary} - Teaching: {Subject1}, {Subject2}";
        }   
    }

    public class Admin : Person
    {
        public double Salary { get; set; } 
        public bool IsFullTime { get; set; } 
        public int WorkingHours { get; set; } 
        public Admin(int id, string n, string t, string e, double s, bool ft, int h)
            : base(id,n , t, e, "Administration") { Salary = s; IsFullTime = ft; WorkingHours = h; }
    }

    public class Student : Person
    {
        public string Subject1 { get; set; } 
        public string Subject2 { get; set; }
        public string Subject3 { get; set; }
        public Student(int id, string n, string t, string e, string s1, string s2, string s3)
            : base(id, n, t, e, "Students") { Subject1 = s1; Subject2 = s2; Subject3 = s3; }
    }
}