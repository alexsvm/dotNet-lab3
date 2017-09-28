namespace dotNet_lab3
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.textBoxLN = new System.Windows.Forms.TextBox();
            this.textBoxMN = new System.Windows.Forms.TextBox();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.edCourseLCount = new System.Windows.Forms.NumericUpDown();
            this.edCoursePCount = new System.Windows.Forms.NumericUpDown();
            this.edCourseLabCount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edCourseLCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCoursePCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCourseLabCount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStudentInfo);
            this.groupBox1.Controls.Add(this.maskedTextBoxPhone);
            this.groupBox1.Controls.Add(this.listBoxStudents);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxAddr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddStudent);
            this.groupBox1.Controls.Add(this.textBoxLN);
            this.groupBox1.Controls.Add(this.textBoxMN);
            this.groupBox1.Controls.Add(this.textBoxFN);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 274);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Студенты";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(9, 188);
            this.maskedTextBoxPhone.Mask = "+0(000) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(112, 20);
            this.maskedTextBoxPhone.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Адрес:";
            // 
            // textBoxAddr
            // 
            this.textBoxAddr.Location = new System.Drawing.Point(9, 149);
            this.textBoxAddr.Name = "textBoxAddr";
            this.textBoxAddr.Size = new System.Drawing.Size(257, 20);
            this.textBoxAddr.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Отчество:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя:";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(9, 237);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(114, 23);
            this.btnAddStudent.TabIndex = 6;
            this.btnAddStudent.Text = "Добавить";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxLN
            // 
            this.textBoxLN.Location = new System.Drawing.Point(9, 110);
            this.textBoxLN.Name = "textBoxLN";
            this.textBoxLN.Size = new System.Drawing.Size(141, 20);
            this.textBoxLN.TabIndex = 5;
            // 
            // textBoxMN
            // 
            this.textBoxMN.Location = new System.Drawing.Point(9, 71);
            this.textBoxMN.Name = "textBoxMN";
            this.textBoxMN.Size = new System.Drawing.Size(141, 20);
            this.textBoxMN.TabIndex = 4;
            // 
            // textBoxFN
            // 
            this.textBoxFN.Location = new System.Drawing.Point(9, 32);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(141, 20);
            this.textBoxFN.TabIndex = 3;
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Items.AddRange(new object[] {
            "",
            ""});
            this.listBoxStudents.Location = new System.Drawing.Point(303, 19);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(448, 199);
            this.listBoxStudents.TabIndex = 5;
            this.listBoxStudents.SelectedIndexChanged += new System.EventHandler(this.listBoxStudents_SelectedIndexChanged);
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Location = new System.Drawing.Point(300, 237);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(31, 13);
            this.lblStudentInfo.TabIndex = 6;
            this.lblStudentInfo.Text = "        ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.edCourseLabCount);
            this.groupBox2.Controls.Add(this.edCoursePCount);
            this.groupBox2.Controls.Add(this.edCourseLCount);
            this.groupBox2.Controls.Add(this.textBoxCourseName);
            this.groupBox2.Controls.Add(this.btnAddCourse);
            this.groupBox2.Controls.Add(this.listBoxCourses);
            this.groupBox2.Location = new System.Drawing.Point(12, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 229);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Предметы";
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.Items.AddRange(new object[] {
            " "});
            this.listBoxCourses.Location = new System.Drawing.Point(303, 19);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(448, 186);
            this.listBoxCourses.TabIndex = 0;
            this.listBoxCourses.SelectedIndexChanged += new System.EventHandler(this.listBoxCourses_SelectedIndexChanged);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(11, 181);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(112, 23);
            this.btnAddCourse.TabIndex = 1;
            this.btnAddCourse.Text = "Добавить";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(11, 35);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(257, 20);
            this.textBoxCourseName.TabIndex = 2;
            // 
            // edCourseLCount
            // 
            this.edCourseLCount.Location = new System.Drawing.Point(139, 64);
            this.edCourseLCount.Name = "edCourseLCount";
            this.edCourseLCount.Size = new System.Drawing.Size(56, 20);
            this.edCourseLCount.TabIndex = 3;
            // 
            // edCoursePCount
            // 
            this.edCoursePCount.Location = new System.Drawing.Point(139, 97);
            this.edCoursePCount.Name = "edCoursePCount";
            this.edCoursePCount.Size = new System.Drawing.Size(56, 20);
            this.edCoursePCount.TabIndex = 4;
            // 
            // edCourseLabCount
            // 
            this.edCourseLabCount.Location = new System.Drawing.Point(139, 132);
            this.edCourseLabCount.Name = "edCourseLabCount";
            this.edCourseLabCount.Size = new System.Drawing.Size(56, 20);
            this.edCourseLabCount.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Наименование курса:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Лекций:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Практических занятий:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Лабораторных занятий:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 604);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Студенты и все такое...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edCourseLCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCoursePCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCourseLabCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox textBoxLN;
        private System.Windows.Forms.TextBox textBoxMN;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddr;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown edCourseLabCount;
        private System.Windows.Forms.NumericUpDown edCoursePCount;
        private System.Windows.Forms.NumericUpDown edCourseLCount;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

