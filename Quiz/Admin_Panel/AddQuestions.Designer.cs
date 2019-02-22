namespace Quiz
{
    partial class AddQuestions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.examsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.quiz_newDataSet = new Quiz.Quiz_newDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.examsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
          
            this.examsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
         
            this.quizDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
        
            this.examsTableAdapter1 = new Quiz.Quiz_newDataSetTableAdapters.examsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_newDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource1)).BeginInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSetBindingSource)).BeginInit();
        
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(50, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 33);
            this.button3.TabIndex = 17;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(599, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Exam";
           
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(435, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Exam";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.examsBindingSource2;
            this.comboBox1.DisplayMember = "exam_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(499, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "exam_id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // examsBindingSource2
            // 
            this.examsBindingSource2.DataMember = "exams";
            this.examsBindingSource2.DataSource = this.quiz_newDataSet;
            // 
            // quiz_newDataSet
            // 
            this.quiz_newDataSet.DataSetName = "Quiz_newDataSet";
            this.quiz_newDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(25, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Correct";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Option D";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Option C";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Option B";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Option A";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(310, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Question";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(118, 337);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(230, 22);
            this.textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(118, 273);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(230, 22);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 228);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(230, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 179);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(230, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(664, 22);
            this.textBox1.TabIndex = 0;
            // 
            // examsBindingSource1
            // 
            this.examsBindingSource1.DataMember = "exams";
        
            // 
            // quizDataSet
            // 
           
            // 
            // examsBindingSource
            // 
            this.examsBindingSource.DataMember = "exams";
            this.examsBindingSource.DataSource = this.quizDataSetBindingSource;
            // 
            // quizDataSet2
            // 
            
            // 
            // quizDataSet2BindingSource
            // 
          
            this.quizDataSet2BindingSource.Position = 0;
            // 
            // examsTableAdapter
            // 
        
            // 
            // examsTableAdapter1
            // 
            this.examsTableAdapter1.ClearBeforeFill = true;
            // 
            // AddQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 562);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddQuestions";
            this.Text = "AddQuestions";
            this.Load += new System.EventHandler(this.AddQuestions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_newDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource1)).EndInit();
       
            ((System.ComponentModel.ISupportInitialize)(this.examsBindingSource)).EndInit();
            
       
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource quizDataSetBindingSource;
    
        private System.Windows.Forms.BindingSource examsBindingSource;
        
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource quizDataSet2BindingSource;
      
        private System.Windows.Forms.BindingSource examsBindingSource1;
        
        private Quiz_newDataSet quiz_newDataSet;
        private System.Windows.Forms.BindingSource examsBindingSource2;
        private Quiz_newDataSetTableAdapters.examsTableAdapter examsTableAdapter1;
        private System.Windows.Forms.Button button3;
    }
}