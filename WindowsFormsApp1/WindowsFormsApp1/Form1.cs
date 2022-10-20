using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Customer> customers = new List<Customer>();
        List<Employee> employees = new List<Employee>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            int Id = Convert.ToInt16(textBox1.Text);
            String FirstName = textBox2.Text;
            String LastName = textBox3.Text;
            String PhoneNumber = textBox4.Text;

            customer.Id = Id;
            customer.FirstName = FirstName;
            customer.LastName = LastName;
            customer.PhoneNumber = PhoneNumber;


            customers.Add(customer);
            clearTxtBox();
            comboBox1.Items.Add(customer.Id);
        }
        public void clearTxtBox()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            int Id = Convert.ToInt16(textBox1.Text);
            String FirstName = textBox2.Text;
            String LastName = textBox3.Text;
            String PhoneNumber = textBox4.Text;

            employee.Id = Id;
            employee.FirstName = FirstName;
            employee.LastName = LastName;
            employee.PhoneNumber = PhoneNumber;


            employees.Add(employee);
            clearTxtBox();
            comboBox2.Items.Add(employee.Id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Customer customer in customers)
            {
                if (customer.Id == Convert.ToInt16(comboBox1.Text))
                {
                    listBox1.Items.Add(customer.FirstName + " " + customer.LastName);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Employee employee in employees)
            {
                if (employee.Id == Convert.ToInt16(comboBox2.Text))
                {
                    listBox1.Items.Add(employee.FirstName + " " + employee.LastName);
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String toSearch = listBox1.SelectedItem.ToString();
            customers.RemoveAll(customer => ((customer.FirstName + " " + customer.LastName) == toSearch));
            listBox1.Items.Remove(listBox1.SelectedItem);
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String toSearch = listBox1.SelectedItem.ToString();
            customers.RemoveAll(employee => ((employee.FirstName + " " + employee.LastName) == toSearch));
            listBox1.Items.Remove(listBox1.SelectedItem);
            comboBox2.Items.Remove(comboBox2.SelectedItem);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
