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
    public partial class Salaries : Form
    {
        functions Con;
        public Salaries()
        {
            InitializeComponent();
            Con = new functions();
            ShowSalaries();
            GetEmployees();
        }
        private void GetEmployees()
        {
            string Query = "Select * from EmployeeTb1";
            EmpNameTb.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            EmpNameTb.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            EmpNameTb.DataSource = Con.GetData(Query);
        }
        private void GetSalary()
        {
            string Query = "Select EmpSal from EmployeeTb1 where EmpId = {0}";
            Query = string.Format(Query, EmpNameTb.SelectedValue.ToString());
            EmpNameTb.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            EmpNameTb.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            EmpNameTb.DataSource = Con.GetData(Query);
        }
        private void ShowSalaries()
        {
            try
            {
                string Query = "Select * from SalaryTb1";
                SalaryList.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
