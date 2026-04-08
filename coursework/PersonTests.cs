using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using coursework;

namespace coursework.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void Teacher_Initialization_And_GetDetails()
        {
            // Arrange
            int id = 1;
            string name = "John Doe";
            string tel = "123456789";
            string email = "john@example.com";
            double salary = 50000;
            string subject1 = "Math";
            string subject2 = "Science";

            // Act
            Teacher teacher = new Teacher(id, name, tel, email, salary, subject1, subject2);
            string details = teacher.GetDetails();

            // Assert
            Assert.AreEqual(id, teacher.Id);
            Assert.AreEqual(name, teacher.Name);
            Assert.AreEqual(tel, teacher.Telephone);
            Assert.AreEqual(email, teacher.Email);
            Assert.AreEqual("Teaching Staff", teacher.Role);
            Assert.AreEqual(salary, teacher.Salary);
            Assert.AreEqual(subject1, teacher.Subject1);
            Assert.AreEqual(subject2, teacher.Subject2);
            Assert.AreEqual($"[Teacher] {name} - Salary: {salary} - Teaching: {subject1}, {subject2}", details);
            
            Console.WriteLine("Teacher_Initialization_And_GetDetails test passed successfully!");
        }

        [TestMethod]
        public void Admin_Initialization()
        {
            // Arrange
            int id = 2;
            string name = "Jane Smith";
            string tel = "987654321";
            string email = "jane@example.com";
            double salary = 40000;
            bool isFullTime = true;
            int workingHours = 40;

            // Act
            Admin admin = new Admin(id, name, tel, email, salary, isFullTime, workingHours);

            // Assert
            Assert.AreEqual(id, admin.Id);
            Assert.AreEqual(name, admin.Name);
            Assert.AreEqual(tel, admin.Telephone);
            Assert.AreEqual(email, admin.Email);
            Assert.AreEqual("Administration", admin.Role);
            Assert.AreEqual(salary, admin.Salary);
            Assert.IsTrue(admin.IsFullTime);
            Assert.AreEqual(workingHours, admin.WorkingHours);
            
            Console.WriteLine("Admin_Initialization test passed successfully!");
        }

        [TestMethod]
        public void Student_Initialization()
        {
            // Arrange
            int id = 3;
            string name = "Bob Builder";
            string tel = "555123456";
            string email = "bob@example.com";
            string subject1 = "Art";
            string subject2 = "History";
            string subject3 = "Music";

            // Act
            Student student = new Student(id, name, tel, email, subject1, subject2, subject3);

            // Assert
            Assert.AreEqual(id, student.Id);
            Assert.AreEqual(name, student.Name);
            Assert.AreEqual(tel, student.Telephone);
            Assert.AreEqual(email, student.Email);
            Assert.AreEqual("Students", student.Role);
            Assert.AreEqual(subject1, student.Subject1);
            Assert.AreEqual(subject2, student.Subject2);
            Assert.AreEqual(subject3, student.Subject3);
            
            Console.WriteLine("Student_Initialization test passed successfully!");
        }
    }
}
