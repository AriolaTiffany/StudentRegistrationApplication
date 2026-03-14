using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ArrayList months = new ArrayList
            { "January", "February", "March", "April", "May", 
              "June", "July", "August", "September", "October", "November", "December" };

            foreach (string month in months)
            {
                CBMonth.Items.Add(month);
            }

            for (int day = 1; day <= 31; day++)
            {
                CBDay.Items.Add(day.ToString());
            }

            for (int year = 1980; year <= 2026; year++)
            {
                CBYear.Items.Add(year.ToString());
            }

            ArrayList programs = new ArrayList
            {
                "Bachelor of Science in Computer Science",
                "Bachelor of Science in Information Technology",
                "Bachelor of Science in Information Systems",
                "Bachelor of Science in Computer Engineering",
            };

            foreach (string program in programs)
            {
                CBProgram.Items.Add(program);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BTNRegister_Click(object sender, EventArgs e)
        {
            string lastName = TBLastName.Text;
            string firstName = TBFirstName.Text;
            string middleName = TBMiddleName.Text;

            string gender = "";
            if (RBTNMale.Checked)
            {
                gender = "Male";
            }
            else if (RBTNFemale.Checked)
                {
                    gender = "Female";
                }

            string day = CBDay.Text;
            string month = CBMonth.Text;
            string year = CBYear.Text;
            string program = CBProgram.Text;

            MessageBox.Show(
                $"Student Name: {firstName} {middleName} {lastName}\n" +
                $"Gender: {gender}\n" +
                $"Date of Birth: {day}/{month}/{year}\n" +
                $"Program: {program}"
            );
        }
    }
    }
   

