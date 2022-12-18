using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_M_S
{
    public partial class Employee : Form
    {
        functions Con;
        public Employee()
        {
            InitializeComponent();
            Con = new functions();
            ShowEmp();
        }
        private void ShowEmp()
        {
            string Query = "Select * from EmployeeTb1";
            EmployeeList.DataSource = Con.GetData(Query);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void GetDepartment()
        {
            string Query = "Select * from DepartmentTb1";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
