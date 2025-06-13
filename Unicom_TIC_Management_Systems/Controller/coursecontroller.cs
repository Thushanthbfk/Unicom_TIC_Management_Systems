using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom_TIC_Management_Systems.Data;
using Unicom_TIC_Management_Systems.Models;

namespace Unicom_TIC_Management_Systems.Controller
{
    internal class coursecontroller
    {
      
        
            public void CreateCourse(Course course)
            {
                using (SQLiteConnection connection = DBConfigs.GetConnection())
                {
                    string query = "INSERT INTO Courses (CourseName) VALUES (@CourseName)";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseName", course.course_name);
                        command.ExecuteNonQuery();
                    }
                }
            }

            public List<Course> GetCourses()
            {
                List<Course> courses = new List<Course>();

                using (SQLiteConnection connection = DBConfigs.GetConnection())
                {
                    string query = "SELECT * FROM Courses";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Course course = new Course
                            {
                                course_id = reader.GetInt32(0),
                                course_name = reader.GetString(1)
                            };

                            courses.Add(course);
                        }
                    }
                }

                return courses;
            }
        }
    }



























   


    
    



    
