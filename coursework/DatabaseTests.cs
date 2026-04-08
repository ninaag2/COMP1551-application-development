using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;

namespace coursework.Tests
{
    [TestClass]
    public class DatabaseTests
    {
        // Database connection string (identical to Form1)
        private string connectionString = "server=localhost;port=3306;user=root;password=1234;database=new_schema;";

        [TestMethod]
        public void Test_Insert_And_Verify_Database()
        {
            // --- ARRANGE: Prepare data ---
            string testName = "TestUser_Add_" + Guid.NewGuid().ToString().Substring(0, 5); // Random name to avoid duplication
            string testPhone = "0123456789";
            string testEmail = "test@example.com";
            string testRole = "Student";
            double testSalary = 0;
            string testInfo = "S1, S2, S3";
            long insertedId = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // --- ACT 1: Test Insert (Add) ---
                string insertQuery = "INSERT INTO Person (name, phone, email, role, salary, info) VALUES (@n, @p, @e, @r, @s, @i)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@n", testName);
                    cmd.Parameters.AddWithValue("@p", testPhone);
                    cmd.Parameters.AddWithValue("@e", testEmail);
                    cmd.Parameters.AddWithValue("@r", testRole);
                    cmd.Parameters.AddWithValue("@s", testSalary);
                    cmd.Parameters.AddWithValue("@i", testInfo);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Assert.AreEqual(1, rowsAffected, "Expected 1 row to be inserted into the DB"); // Check if insert was successful

                    // Get the auto-generated ID
                    insertedId = cmd.LastInsertedId;
                }

                // --- ASSERT 1: Fetch to verify ---
                string selectQuery = "SELECT name, email FROM Person WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", insertedId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        Assert.IsTrue(reader.Read(), "Should be able to read the saved data");
                        Assert.AreEqual(testName, reader["name"].ToString());
                        Assert.AreEqual(testEmail, reader["email"].ToString());
                    }
                }

                // --- CLEAN UP: Self-cleanup to avoid cluttering the database ---
                string deleteQuery = "DELETE FROM Person WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", insertedId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        [TestMethod]
        public void Test_Update_Database()
        {
            
            string initialName = "TestUser_Edit";
            long insertedId = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string insertQuery = "INSERT INTO Person (name, phone, email, role, salary, info) VALUES (@n, '', '', 'Admin', 0, '')";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@n", initialName);
                    cmd.ExecuteNonQuery();
                    insertedId = cmd.LastInsertedId;
                }

                // --- ACT: Update (Edit) this Person (Same as UpdateDatabase method in Form1) ---
                string updatedName = "TestUser_Edit_Success";
                string updatedPhone = "999999999";
                string updatedEmail = "edit@example.com";
                
                string updateQuery = "UPDATE Person SET name=@n, phone=@p, email=@e WHERE id=@id";
                using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@n", updatedName);
                    cmd.Parameters.AddWithValue("@p", updatedPhone);
                    cmd.Parameters.AddWithValue("@e", updatedEmail);
                    cmd.Parameters.AddWithValue("@id", insertedId);
                    
                    int rowsUpdated = cmd.ExecuteNonQuery();
                    Assert.AreEqual(1, rowsUpdated, "Expected 1 row to be updated");
                }

               
                string selectQuery = "SELECT name, phone, email FROM Person WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", insertedId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        Assert.IsTrue(reader.Read());
                        Assert.AreEqual(updatedName, reader["name"].ToString());
                        Assert.AreEqual(updatedPhone, reader["phone"].ToString());
                        Assert.AreEqual(updatedEmail, reader["email"].ToString());
                    }
                }

                // --- CLEAN UP: ---
                string deleteQuery = "DELETE FROM Person WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", insertedId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
