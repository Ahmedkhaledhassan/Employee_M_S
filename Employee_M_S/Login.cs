namespace Employee_M_S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UNameTb.Text == "" ||PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }else if(UNameTb.Text =="ahmed" && PasswordTb.Text=="khaled")
            {
                Employee Obj = new Employee();
                Obj.Show();
                this.Hide();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 Obj = new Form1();
            Obj.Show();
            this.Hide();
        }

        private void ResetTb_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PasswordTb.Text = "";
        }
    }
}