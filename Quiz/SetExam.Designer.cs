namespace Quiz
{
    partial class SetExam
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.studentrecordBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quizDataSet2 = new Quiz.QuizDataSet2();
            this.quizDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentrecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_recordTableAdapter1 = new Quiz.QuizDataSet2TableAdapters.student_recordTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentrecordBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentrecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1048, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Batch Code";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.studentrecordBindingSource1;
            this.comboBox1.DisplayMember = "student_batchcode";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "student_batchcode";
            // 
            // studentrecordBindingSource1
            // 
            this.studentrecordBindingSource1.DataMember = "student_record";
            this.studentrecordBindingSource1.DataSource = this.quizDataSet2;
            // 
            // quizDataSet2
            // 
            this.quizDataSet2.DataSetName = "QuizDataSet2";
            this.quizDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentrecordBindingSource
            // 
            this.studentrecordBindingSource.DataMember = "student_record";
            // 
            // student_recordTableAdapter1
            // 
            this.student_recordTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fetch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SetExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SetExam";
            this.Text = "SetExam";
            this.Load += new System.EventHandler(this.SetExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentrecordBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentrecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource quizDataSetBindingSource;
        
     
        private System.Windows.Forms.BindingSource studentrecordBindingSource;
   
        private QuizDataSet2 quizDataSet2;
        private System.Windows.Forms.BindingSource studentrecordBindingSource1;
        private QuizDataSet2TableAdapters.student_recordTableAdapter student_recordTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}