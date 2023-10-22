using System.Data;
using System.Data.SqlClient;

namespace StudentsDatabaseApp
{
	public partial class Form1 : Form
	{
		SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=StudentsDatabase;Integrated Security=True");
		public int StudentID;
		public Form1()
		{
			InitializeComponent();
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			GetStudentsRecord();
		}

		private void GetStudentsRecord()
		{

			SqlCommand cmd = new SqlCommand("select * from StudentsTable", con);
			DataTable dt = new DataTable();

			con.Open();

			SqlDataReader sdr = cmd.ExecuteReader();
			dt.Load(sdr);
			con.Close();

			StudentRecordDataGridView.DataSource = dt;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (IsValid())
			{

				// Create a list to store the selected programming languages
				List<string> selectedLanguages = new List<string>();

				if (CCheckBox.Checked)
					selectedLanguages.Add("C/C++");
				if (CSharpCheckBox.Checked)
					selectedLanguages.Add("C#");
				if (VBCheckBox.Checked)
					selectedLanguages.Add("VB");
				if (DelphiCheckBox.Checked)
					selectedLanguages.Add("Delphi");

				// Join the selected languages into a single string
				string languages = string.Join(", ", selectedLanguages);

				if (languages == string.Empty)
				{
					languages += "None";
				}


				SqlCommand cmd = new SqlCommand("INSERT INTO StudentsTable VALUES (@name, @FatherName, @Roll, @Address, @Mobile, @ProgrammingLanguages)", con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@name", txtStudentName.Text);
				cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
				cmd.Parameters.AddWithValue("@Roll", txtRollNumber.Text);
				cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
				cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
				cmd.Parameters.AddWithValue("@ProgrammingLanguages", languages);

				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();

				MessageBox.Show("New student is successfully saved into the database!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

				GetStudentsRecord();
				ResetFormControls();


			}
		}

		private bool IsValid()
		{
			if (txtStudentName.Text == string.Empty)
			{
				MessageBox.Show("Student Name is required!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;

		}

		private void button4_Click(object sender, EventArgs e)
		{
			ResetFormControls();
		}

		private void ResetFormControls()
		{
			StudentID = 0;
			txtStudentName.Clear();
			txtFatherName.Clear();
			txtAddress.Clear();
			txtMobile.Clear();
			txtRollNumber.Clear();

			txtStudentName.Focus();
		}

		private void StudentRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			StudentID = Convert.ToInt32(StudentRecordDataGridView.SelectedRows[0].Cells[0].Value);
			txtStudentName.Text = StudentRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
			txtFatherName.Text = StudentRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
			txtRollNumber.Text = StudentRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
			txtAddress.Text = StudentRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
			txtMobile.Text = StudentRecordDataGridView.SelectedRows[0].Cells[5].Value.ToString();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (StudentID > 0)
			{
				SqlCommand cmd = new SqlCommand("UPDATE StudentsTable SET Name = @name, FatherName = @FatherName, RollNumber = @Roll, Address = @Address, Mobile = @Mobile WHERE StudentId = @ID", con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@name", txtStudentName.Text);
				cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
				cmd.Parameters.AddWithValue("@Roll", txtRollNumber.Text);
				cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
				cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
				cmd.Parameters.AddWithValue("@ID", this.StudentID);

				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();

				MessageBox.Show("Student information is updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

				GetStudentsRecord();
				ResetFormControls();

			}
			else
			{
				MessageBox.Show("Please select a student to update the information!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (StudentID > 0)
			{
				SqlCommand cmd = new SqlCommand("DELETE FROM StudentsTable WHERE StudentId = @ID", con);
				cmd.CommandType = CommandType.Text;

				cmd.Parameters.AddWithValue("@ID", this.StudentID);
				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();

				MessageBox.Show("Student is deleted Successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

				GetStudentsRecord();
				ResetFormControls();
			}
			else
			{
				MessageBox.Show("Please select a student to delete the information!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


	}
}