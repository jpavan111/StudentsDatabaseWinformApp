namespace StudentsDatabaseApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			StudentName = new Label();
			txtStudentName = new TextBox();
			InsertButton = new Button();
			StudentRecordDataGridView = new DataGridView();
			UpdateButton = new Button();
			DeleteButton = new Button();
			ResetButton = new Button();
			label5 = new Label();
			txtMobile = new TextBox();
			ProgrammingLanguages = new Label();
			CCheckBox = new CheckBox();
			CSharpCheckBox = new CheckBox();
			VBCheckBox = new CheckBox();
			DelphiCheckBox = new CheckBox();
			SearchButton = new Button();
			SearchTextBox = new TextBox();
			label1 = new Label();
			MaleCheckBox = new CheckBox();
			FemaleCheckBox = new CheckBox();
			label2 = new Label();
			txtHobbies = new TextBox();
			((System.ComponentModel.ISupportInitialize)StudentRecordDataGridView).BeginInit();
			SuspendLayout();
			// 
			// StudentName
			// 
			StudentName.AutoSize = true;
			StudentName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			StudentName.Location = new Point(12, 32);
			StudentName.Name = "StudentName";
			StudentName.Size = new Size(100, 19);
			StudentName.TabIndex = 0;
			StudentName.Text = "Student Name:";
			// 
			// txtStudentName
			// 
			txtStudentName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			txtStudentName.Location = new Point(118, 29);
			txtStudentName.Name = "txtStudentName";
			txtStudentName.Size = new Size(171, 25);
			txtStudentName.TabIndex = 1;
			// 
			// InsertButton
			// 
			InsertButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			InsertButton.Location = new Point(18, 208);
			InsertButton.Name = "InsertButton";
			InsertButton.Size = new Size(94, 39);
			InsertButton.TabIndex = 2;
			InsertButton.Text = "Insert";
			InsertButton.UseVisualStyleBackColor = true;
			InsertButton.Click += InsertButton_Click;
			// 
			// StudentRecordDataGridView
			// 
			StudentRecordDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			StudentRecordDataGridView.Location = new Point(12, 253);
			StudentRecordDataGridView.Name = "StudentRecordDataGridView";
			StudentRecordDataGridView.RowTemplate.Height = 25;
			StudentRecordDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			StudentRecordDataGridView.Size = new Size(606, 216);
			StudentRecordDataGridView.TabIndex = 3;
			StudentRecordDataGridView.CellClick += StudentRecordDataGridView_CellClick;
			// 
			// UpdateButton
			// 
			UpdateButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			UpdateButton.Location = new Point(186, 208);
			UpdateButton.Name = "UpdateButton";
			UpdateButton.Size = new Size(94, 39);
			UpdateButton.TabIndex = 2;
			UpdateButton.Text = "Update";
			UpdateButton.UseVisualStyleBackColor = true;
			UpdateButton.Click += UpdateButton_Click;
			// 
			// DeleteButton
			// 
			DeleteButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			DeleteButton.Location = new Point(354, 208);
			DeleteButton.Name = "DeleteButton";
			DeleteButton.Size = new Size(94, 39);
			DeleteButton.TabIndex = 2;
			DeleteButton.Text = "Delete";
			DeleteButton.UseVisualStyleBackColor = true;
			DeleteButton.Click += DeleteButton_Click;
			// 
			// ResetButton
			// 
			ResetButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			ResetButton.Location = new Point(522, 208);
			ResetButton.Name = "ResetButton";
			ResetButton.Size = new Size(94, 39);
			ResetButton.TabIndex = 2;
			ResetButton.Text = "Reset";
			ResetButton.UseVisualStyleBackColor = true;
			ResetButton.Click += ResetButton_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(12, 72);
			label5.Name = "label5";
			label5.Size = new Size(54, 19);
			label5.TabIndex = 4;
			label5.Text = "Mobile:";
			// 
			// txtMobile
			// 
			txtMobile.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			txtMobile.Location = new Point(118, 72);
			txtMobile.Name = "txtMobile";
			txtMobile.Size = new Size(171, 25);
			txtMobile.TabIndex = 1;
			// 
			// ProgrammingLanguages
			// 
			ProgrammingLanguages.AutoSize = true;
			ProgrammingLanguages.Location = new Point(315, 76);
			ProgrammingLanguages.Name = "ProgrammingLanguages";
			ProgrammingLanguages.Size = new Size(144, 15);
			ProgrammingLanguages.TabIndex = 5;
			ProgrammingLanguages.Text = "Programming Languages:";
			// 
			// CCheckBox
			// 
			CCheckBox.AutoSize = true;
			CCheckBox.Location = new Point(465, 76);
			CCheckBox.Name = "CCheckBox";
			CCheckBox.Size = new Size(63, 19);
			CCheckBox.TabIndex = 6;
			CCheckBox.Text = "C/C++";
			CCheckBox.UseVisualStyleBackColor = true;
			// 
			// CSharpCheckBox
			// 
			CSharpCheckBox.AutoSize = true;
			CSharpCheckBox.Location = new Point(465, 99);
			CSharpCheckBox.Name = "CSharpCheckBox";
			CSharpCheckBox.Size = new Size(41, 19);
			CSharpCheckBox.TabIndex = 6;
			CSharpCheckBox.Text = "C#";
			CSharpCheckBox.UseVisualStyleBackColor = true;
			// 
			// VBCheckBox
			// 
			VBCheckBox.AutoSize = true;
			VBCheckBox.Location = new Point(465, 122);
			VBCheckBox.Name = "VBCheckBox";
			VBCheckBox.Size = new Size(40, 19);
			VBCheckBox.TabIndex = 6;
			VBCheckBox.Text = "VB";
			VBCheckBox.UseVisualStyleBackColor = true;
			// 
			// DelphiCheckBox
			// 
			DelphiCheckBox.AutoSize = true;
			DelphiCheckBox.Location = new Point(465, 145);
			DelphiCheckBox.Name = "DelphiCheckBox";
			DelphiCheckBox.Size = new Size(60, 19);
			DelphiCheckBox.TabIndex = 6;
			DelphiCheckBox.Text = "Delphi";
			DelphiCheckBox.UseVisualStyleBackColor = true;
			// 
			// SearchButton
			// 
			SearchButton.Location = new Point(18, 160);
			SearchButton.Name = "SearchButton";
			SearchButton.Size = new Size(94, 33);
			SearchButton.TabIndex = 7;
			SearchButton.Text = "Search";
			SearchButton.UseVisualStyleBackColor = true;
			SearchButton.Click += SearchButton_Click;
			// 
			// SearchTextBox
			// 
			SearchTextBox.Location = new Point(118, 166);
			SearchTextBox.Name = "SearchTextBox";
			SearchTextBox.Size = new Size(171, 23);
			SearchTextBox.TabIndex = 8;
			SearchTextBox.Text = "Enter Name/Number";
			SearchTextBox.TextChanged += SearchTextBox_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(314, 34);
			label1.Name = "label1";
			label1.Size = new Size(48, 15);
			label1.TabIndex = 9;
			label1.Text = "Gender:";
			// 
			// MaleCheckBox
			// 
			MaleCheckBox.AutoSize = true;
			MaleCheckBox.Location = new Point(368, 35);
			MaleCheckBox.Name = "MaleCheckBox";
			MaleCheckBox.Size = new Size(52, 19);
			MaleCheckBox.TabIndex = 6;
			MaleCheckBox.Text = "Male";
			MaleCheckBox.UseVisualStyleBackColor = true;
			MaleCheckBox.CheckedChanged += MaleCheckBox_CheckedChanged;
			// 
			// FemaleCheckBox
			// 
			FemaleCheckBox.AutoSize = true;
			FemaleCheckBox.Location = new Point(442, 35);
			FemaleCheckBox.Name = "FemaleCheckBox";
			FemaleCheckBox.Size = new Size(64, 19);
			FemaleCheckBox.TabIndex = 6;
			FemaleCheckBox.Text = "Female";
			FemaleCheckBox.UseVisualStyleBackColor = true;
			FemaleCheckBox.CheckedChanged += FemaleCheckBox_CheckedChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(12, 121);
			label2.Name = "label2";
			label2.Size = new Size(62, 19);
			label2.TabIndex = 4;
			label2.Text = "Hobbies:";
			// 
			// txtHobbies
			// 
			txtHobbies.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			txtHobbies.Location = new Point(118, 118);
			txtHobbies.Name = "txtHobbies";
			txtHobbies.Size = new Size(171, 25);
			txtHobbies.TabIndex = 1;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(630, 481);
			Controls.Add(label1);
			Controls.Add(SearchTextBox);
			Controls.Add(SearchButton);
			Controls.Add(DelphiCheckBox);
			Controls.Add(VBCheckBox);
			Controls.Add(CSharpCheckBox);
			Controls.Add(MaleCheckBox);
			Controls.Add(FemaleCheckBox);
			Controls.Add(CCheckBox);
			Controls.Add(ProgrammingLanguages);
			Controls.Add(label2);
			Controls.Add(label5);
			Controls.Add(StudentRecordDataGridView);
			Controls.Add(ResetButton);
			Controls.Add(DeleteButton);
			Controls.Add(UpdateButton);
			Controls.Add(InsertButton);
			Controls.Add(txtHobbies);
			Controls.Add(txtMobile);
			Controls.Add(txtStudentName);
			Controls.Add(StudentName);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Student Information";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)StudentRecordDataGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label StudentName;
		private TextBox txtStudentName;
		private Button InsertButton;
		private DataGridView StudentRecordDataGridView;
		private Button UpdateButton;
		private Button DeleteButton;
		private Button ResetButton;
		private Label label5;
		private TextBox txtMobile;
		private Label ProgrammingLanguages;
		private CheckBox CCheckBox;
		private CheckBox CSharpCheckBox;
		private CheckBox VBCheckBox;
		private CheckBox DelphiCheckBox;
		private Button SearchButton;
		private TextBox SearchTextBox;
		private Label label1;
		private CheckBox MaleCheckBox;
		private CheckBox FemaleCheckBox;
		private Label label2;
		private TextBox txtHobbies;
	}
}