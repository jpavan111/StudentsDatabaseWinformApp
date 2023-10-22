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
			button1 = new Button();
			StudentRecordDataGridView = new DataGridView();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			txtRollNumber = new TextBox();
			txtAddress = new TextBox();
			txtFatherName = new TextBox();
			txtMobile = new TextBox();
			ProgrammingLanguages = new Label();
			CCheckBox = new CheckBox();
			CSharpCheckBox = new CheckBox();
			VBCheckBox = new CheckBox();
			DelphiCheckBox = new CheckBox();
			SearchButton = new Button();
			textBox1 = new TextBox();
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
			// button1
			// 
			button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			button1.Location = new Point(18, 208);
			button1.Name = "button1";
			button1.Size = new Size(94, 39);
			button1.TabIndex = 2;
			button1.Text = "Insert";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
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
			// button2
			// 
			button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			button2.Location = new Point(186, 208);
			button2.Name = "button2";
			button2.Size = new Size(94, 39);
			button2.TabIndex = 2;
			button2.Text = "Update";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			button3.Location = new Point(354, 208);
			button3.Name = "button3";
			button3.Size = new Size(94, 39);
			button3.TabIndex = 2;
			button3.Text = "Delete";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			button4.Location = new Point(522, 208);
			button4.Name = "button4";
			button4.Size = new Size(94, 39);
			button4.TabIndex = 2;
			button4.Text = "Reset";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(56, 75);
			label2.Name = "label2";
			label2.Size = new Size(56, 19);
			label2.TabIndex = 4;
			label2.Text = "Roll No:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(51, 127);
			label3.Name = "label3";
			label3.Size = new Size(61, 19);
			label3.TabIndex = 4;
			label3.Text = "Address:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(314, 32);
			label4.Name = "label4";
			label4.Size = new Size(91, 19);
			label4.TabIndex = 4;
			label4.Text = "Father Name:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(351, 75);
			label5.Name = "label5";
			label5.Size = new Size(54, 19);
			label5.TabIndex = 4;
			label5.Text = "Mobile:";
			// 
			// txtRollNumber
			// 
			txtRollNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			txtRollNumber.Location = new Point(118, 75);
			txtRollNumber.Name = "txtRollNumber";
			txtRollNumber.Size = new Size(171, 25);
			txtRollNumber.TabIndex = 1;
			// 
			// txtAddress
			// 
			txtAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			txtAddress.Location = new Point(118, 127);
			txtAddress.Name = "txtAddress";
			txtAddress.Size = new Size(171, 25);
			txtAddress.TabIndex = 1;
			// 
			// txtFatherName
			// 
			txtFatherName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			txtFatherName.Location = new Point(411, 29);
			txtFatherName.Name = "txtFatherName";
			txtFatherName.Size = new Size(197, 25);
			txtFatherName.TabIndex = 1;
			// 
			// txtMobile
			// 
			txtMobile.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			txtMobile.Location = new Point(411, 72);
			txtMobile.Name = "txtMobile";
			txtMobile.Size = new Size(197, 25);
			txtMobile.TabIndex = 1;
			// 
			// ProgrammingLanguages
			// 
			ProgrammingLanguages.AutoSize = true;
			ProgrammingLanguages.Location = new Point(314, 114);
			ProgrammingLanguages.Name = "ProgrammingLanguages";
			ProgrammingLanguages.Size = new Size(144, 15);
			ProgrammingLanguages.TabIndex = 5;
			ProgrammingLanguages.Text = "Programming Languages:";
			// 
			// CCheckBox
			// 
			CCheckBox.AutoSize = true;
			CCheckBox.Location = new Point(464, 114);
			CCheckBox.Name = "CCheckBox";
			CCheckBox.Size = new Size(63, 19);
			CCheckBox.TabIndex = 6;
			CCheckBox.Text = "C/C++";
			CCheckBox.UseVisualStyleBackColor = true;
			// 
			// CSharpCheckBox
			// 
			CSharpCheckBox.AutoSize = true;
			CSharpCheckBox.Location = new Point(464, 137);
			CSharpCheckBox.Name = "CSharpCheckBox";
			CSharpCheckBox.Size = new Size(41, 19);
			CSharpCheckBox.TabIndex = 6;
			CSharpCheckBox.Text = "C#";
			CSharpCheckBox.UseVisualStyleBackColor = true;
			// 
			// VBCheckBox
			// 
			VBCheckBox.AutoSize = true;
			VBCheckBox.Location = new Point(464, 160);
			VBCheckBox.Name = "VBCheckBox";
			VBCheckBox.Size = new Size(40, 19);
			VBCheckBox.TabIndex = 6;
			VBCheckBox.Text = "VB";
			VBCheckBox.UseVisualStyleBackColor = true;
			// 
			// DelphiCheckBox
			// 
			DelphiCheckBox.AutoSize = true;
			DelphiCheckBox.Location = new Point(464, 183);
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
			// 
			// textBox1
			// 
			textBox1.Location = new Point(118, 166);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(171, 23);
			textBox1.TabIndex = 8;
			textBox1.Text = "Enter Name/Number";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(630, 481);
			Controls.Add(textBox1);
			Controls.Add(SearchButton);
			Controls.Add(DelphiCheckBox);
			Controls.Add(VBCheckBox);
			Controls.Add(CSharpCheckBox);
			Controls.Add(CCheckBox);
			Controls.Add(ProgrammingLanguages);
			Controls.Add(label3);
			Controls.Add(label4);
			Controls.Add(label5);
			Controls.Add(label2);
			Controls.Add(StudentRecordDataGridView);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(txtAddress);
			Controls.Add(txtRollNumber);
			Controls.Add(txtMobile);
			Controls.Add(txtFatherName);
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
		private Button button1;
		private DataGridView StudentRecordDataGridView;
		private Button button2;
		private Button button3;
		private Button button4;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox txtRollNumber;
		private TextBox txtAddress;
		private TextBox txtFatherName;
		private TextBox txtMobile;
		private Label ProgrammingLanguages;
		private CheckBox CCheckBox;
		private CheckBox CSharpCheckBox;
		private CheckBox VBCheckBox;
		private CheckBox DelphiCheckBox;
		private Button SearchButton;
		private TextBox textBox1;
	}
}