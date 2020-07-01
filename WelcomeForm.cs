using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarForm car = new CarForm();
            car.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DriverForm driver = new DriverForm();
            driver.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DriverListForm driverlist = new DriverListForm();
            driverlist.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarListForm carlist = new CarListForm();
            carlist.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarDeleteForm cardelete = new CarDeleteForm();
            cardelete.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AssignDriverForm assigndriver = new AssignDriverForm();
            assigndriver.Show();
        }
    }
}
