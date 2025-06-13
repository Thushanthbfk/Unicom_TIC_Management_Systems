using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom_TIC_Management_Systems.Controller;
using Unicom_TIC_Management_Systems.Models;

namespace Unicom_TIC_Management_Systems.view
{
    public partial class Courseform : Form
    {
        public Courseform()
        {
            InitializeComponent();
            LoadCourses
                ();
        }
            private void LoadCourses()
            {
                coursecontroller coursecontroller = new coursecontroller();


                List<Course> courses= coursecontroller.GetCourses();
                course_view.DataSource = courses;
            }

        private void Courseform_Load(object sender, EventArgs e)
        {

        }

        private void add_course_button_Click(object sender, EventArgs e)
        {
            
            string courseName =course_name.Text;

            Course newCourse = new Course()
            {
                
                course_name = courseName
            };
            coursecontroller coursecontroller = new coursecontroller();
            coursecontroller.CreateCourse(newCourse);
            MessageBox.Show(" Successfully added");
            LoadCourses();
        }

        private void course_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void course_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void course_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
