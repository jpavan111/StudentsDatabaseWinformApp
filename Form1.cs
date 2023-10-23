using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentsDatabaseApp
{
	public partial class Form1 : Form
	{
		SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=StudentsDatabase;Integrated Security=True");
		public int StudentID;
		public Form1()
		{
			InitializeComponent();

			// Handle CheckedChanged events for both checkboxes
			MaleCheckBox.CheckedChanged += MaleCheckBox_CheckedChanged;
			FemaleCheckBox.CheckedChanged += FemaleCheckBox_CheckedChanged;

			// Handle Enter and Leave events for the TextBox
			txtSearch.Enter += SearchTextBox_Enter;
			txtSearch.Leave += SearchTextBox_Leave;

			// Set the initial hint
			txtSearch.Text = "Enter Name/Phone number";
			txtSearch.ForeColor = System.Drawing.Color.LightGray;
		}

		private void SearchTextBox_Enter(object sender, EventArgs e)
		{
			TextBox textBox = (TextBox)sender;

			if (textBox.Text == "Enter Name/Phone number")
			{
				textBox.Text = "";
				textBox.ForeColor = System.Drawing.Color.Black; // Set the text color to the desired color
			}
		}

		private void SearchTextBox_Leave(object sender, EventArgs e)
		{
			TextBox textBox = (TextBox)sender;

			if (string.IsNullOrWhiteSpace(textBox.Text))
			{
				textBox.Text = "Enter Name/Phone number";
				textBox.ForeColor = System.Drawing.Color.LightGray;
			}
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			txtStudentName.Focus();
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
			StudentRecordDataGridView.ClearSelection();

		}

		private void InsertButton_Click(object sender, EventArgs e)
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

				String Gender = "";

				if (MaleCheckBox.Checked)
					Gender = "Male";
				if (FemaleCheckBox.Checked)
					Gender = "Female";


				SqlCommand cmd = new SqlCommand("INSERT INTO StudentsTable VALUES (@name, @Mobile, @ProgrammingLanguages, @Hobbies, @Gender)", con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@name", txtStudentName.Text);
				cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
				cmd.Parameters.AddWithValue("@ProgrammingLanguages", languages);
				cmd.Parameters.AddWithValue("@Hobbies", txtHobbies.Text);
				cmd.Parameters.AddWithValue("@Gender", Gender);

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

			if (txtMobile.Text.Length < 10)
			{
				MessageBox.Show("Please Enter a Valid mobile number!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;

		}

		private void ResetButton_Click(object sender, EventArgs e)
		{
			ResetFormControls();
		}

		private void ResetFormControls()
		{
			StudentID = 0;
			txtStudentName.Clear();
			txtMobile.Clear();
			txtHobbies.Clear();
			txtSearch.Clear();
			

			MaleCheckBox.Checked = false;
			FemaleCheckBox.Checked = false;
			CCheckBox.Checked = false;
			CSharpCheckBox.Checked = false;
			VBCheckBox.Checked = false;
			DelphiCheckBox.Checked = false;

			txtStudentName.Focus();
		}

		private void StudentRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			StudentID = Convert.ToInt32(StudentRecordDataGridView.SelectedRows[0].Cells[0].Value);
			txtStudentName.Text = StudentRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
			txtMobile.Text = StudentRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
			string languages = StudentRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();

			if (languages.Contains("C/C++"))
				CCheckBox.Checked = true;
			if (languages.Contains("C#"))
				CSharpCheckBox.Checked = true;
			if (languages.Contains("VB"))
				VBCheckBox.Checked = true;
			if (languages.Contains("Delphi"))
				DelphiCheckBox.Checked = true;



			txtHobbies.Text = StudentRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();

			string Gender = StudentRecordDataGridView.SelectedRows[0].Cells[5].Value.ToString();

			if (Gender.Contains("Male"))
				MaleCheckBox.Checked = true;
			if (Gender.Contains("Female"))
				FemaleCheckBox.Checked = true;

			// Enable the checkboxes
			CCheckBox.Enabled = true;
			CSharpCheckBox.Enabled = true;
			VBCheckBox.Enabled = true;
			DelphiCheckBox.Enabled = true;
			MaleCheckBox.Enabled = true;
			FemaleCheckBox.Enabled = true;

		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{
			if (StudentID > 0)
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

				String Gender = "";

				if (MaleCheckBox.Checked)
					Gender = "Male";
				if (FemaleCheckBox.Checked)
					Gender = "Female";

				SqlCommand cmd = new SqlCommand("UPDATE StudentsTable SET Name = @name, Mobile = @Mobile, ProgrammingLanguages = @languages, Hobbies = @Hobbies, Gender = @gender WHERE StudentId = @ID", con);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@ID", this.StudentID);
				cmd.Parameters.AddWithValue("@name", txtStudentName.Text);
				cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
				cmd.Parameters.AddWithValue("@languages", languages);
				cmd.Parameters.AddWithValue("@Hobbies", txtHobbies.Text);
				cmd.Parameters.AddWithValue("@Gender", Gender);

				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();

				MessageBox.Show("Student information is updated Successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

				GetStudentsRecord();
				ResetFormControls();

			}
			else
			{
				MessageBox.Show("Please select (click on grid entry) a student to update the information!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
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

		private void SearchTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void SearchButton_Click(object sender, EventArgs e)
		{
			StudentRecordDataGridView.ClearSelection();
			string keyword = txtSearch.Text;

			string searchQuery = "SELECT StudentID, Name, Mobile, ProgrammingLanguages, Hobbies, Gender FROM StudentsTable " +
								 "WHERE Name LIKE @Keyword OR Mobile LIKE @Keyword;";

			using (SqlCommand searchCommand = new SqlCommand(searchQuery, con))
			{
				searchCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

				using (SqlDataAdapter adapter = new SqlDataAdapter(searchCommand))
				{
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);

					if (dataTable.Rows.Count > 0)
					{
						// Display the search results in DataGridView
						//StudentRecordDataGridView.DataSource = dataTable;

						// You can also extract the data from the first row (assuming only one result)
						DataRow firstRow = dataTable.Rows[0];

						StudentID = Convert.ToInt32(firstRow["StudentID"]);
						string name = firstRow["Name"].ToString();
						string mobileNumber = firstRow["Mobile"].ToString();
						string languages = firstRow["ProgrammingLanguages"].ToString();
						string hobbies = firstRow["Hobbies"].ToString();
						string gender = firstRow["Gender"].ToString();


						// Find and select the corresponding row in the DataGridView
						foreach (DataGridViewRow row in StudentRecordDataGridView.Rows)
						{
							if (row.Cells["StudentID"].Value != null &&
								row.Cells["StudentID"].Value.ToString() == StudentID.ToString())
							{
								row.Selected = true;
								break;
							}
						}

						// You can then display this information in your form as needed
						ResetFormControls();
						txtStudentName.Text = name;
						txtMobile.Text = mobileNumber;

						if (languages.Contains("C/C++"))
							CCheckBox.Checked = true;
						if (languages.Contains("C#"))
							CSharpCheckBox.Checked = true;
						if (languages.Contains("VB"))
							VBCheckBox.Checked = true;
						if (languages.Contains("Delphi"))
							DelphiCheckBox.Checked = true;

						txtHobbies.Text = hobbies;

						if (gender.Contains("Male"))
							MaleCheckBox.Checked = true;
						if (gender.Contains("Female"))
							FemaleCheckBox.Checked = true;

						// Enable the checkboxes
						CCheckBox.Enabled = true;
						CSharpCheckBox.Enabled = true;
						VBCheckBox.Enabled = true;
						DelphiCheckBox.Enabled = true;
						MaleCheckBox.Enabled = true;
						FemaleCheckBox.Enabled = true;

					}
					else
					{
						MessageBox.Show("No matching records found.");
					}
				}
			}
		}

		private void MaleCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (MaleCheckBox.Checked)
			{
				FemaleCheckBox.Enabled = false;
			}
			else
			{
				FemaleCheckBox.Enabled = true;
			}

		}

		private void FemaleCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (FemaleCheckBox.Checked)
			{
				MaleCheckBox.Enabled = false;
			}
			else
			{
				MaleCheckBox.Enabled = true;
			}
		}

		private void txtMobile_TextChanged(object sender, EventArgs e)
		{
			string input = txtMobile.Text;
			if (!string.IsNullOrWhiteSpace(input) && !IsNumeric(input))
			{
				MessageBox.Show("Please enter numbers only in the Mobile field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtMobile.Text = ""; // Clear the invalid input
			}
		}

		private bool IsNumeric(string input)
		{
			foreach (char c in input)
			{
				if (!char.IsDigit(c))
				{
					return false;
				}
			}
			return true;
		}
	}
}