namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //we create list here because we will use it in different methods and we need to access it in different methods.
        List<string> students;
        private void Form1_Load(object sender, EventArgs e)
        {
            lblStudentList.Text = "Student List";
            lblStudentName.Text = "Student Name";
            btnAddStudent.Text = "Add ";
            btnRemoveStudent.Text = "Remove";

            students = new List<string>() { "2. Samet Tas", "1. Samet Tas", "3. Samet Tas" };
            lbxStudentList.Items.AddRange(students.ToArray());
            //foreach (var student in students)
            //{
            //    lbxStudentList.Items.Add(student);
            //}
            if (lbxStudentList.SelectedItem == null)
            {
                btnRemoveStudent.Enabled = false;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxStudentName.Text != "")
            {
                students.Add(tbxStudentName.Text);
                //we clear the listbox before adding new items to avoid duplicates         
                lbxStudentList.Items.Clear();
                foreach (var student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
                tbxStudentName.Clear();
            }
            else
                MessageBox.Show("Please enter a student name.");

        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lbxStudentList.SelectedItem != null)
            {
                students.Remove(lbxStudentList.SelectedItem.ToString());
                lbxStudentList.Items.Clear();
                students.ForEach(student => lbxStudentList.Items.Add(student));
                if (lbxStudentList.SelectedItem == null)
                    btnRemoveStudent.Enabled = false;
            }
            else
            {
                MessageBox.Show
                    ("Please select a student to remove.");
            }
        }

        private void lbxStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //we check if there is a selected item in the listbox, if there is we enable the remove button, if there isn't we disable it.
            if (lbxStudentList.SelectedItem != null)
            {
                btnRemoveStudent.Enabled = true;
            }
            else
            {
                btnRemoveStudent.Enabled = false;
            }
        }

        private void tbxStudentName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
