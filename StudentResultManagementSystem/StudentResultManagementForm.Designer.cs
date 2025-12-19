namespace StudentResultManagementSystem
{
    partial class StudentResultManagementForm
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
            this.txtRollNumber = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMarks = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculateResult = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.btnDataToCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRollNumber
            // 
            this.txtRollNumber.Location = new System.Drawing.Point(152, 36);
            this.txtRollNumber.Name = "txtRollNumber";
            this.txtRollNumber.Size = new System.Drawing.Size(100, 22);
            this.txtRollNumber.TabIndex = 0;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(152, 87);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 22);
            this.txtStudentName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "RollNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Name";
            // 
            // dgvMarks
            // 
            this.dgvMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarks.Location = new System.Drawing.Point(52, 157);
            this.dgvMarks.Name = "dgvMarks";
            this.dgvMarks.RowHeadersWidth = 51;
            this.dgvMarks.RowTemplate.Height = 24;
            this.dgvMarks.Size = new System.Drawing.Size(464, 177);
            this.dgvMarks.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Marks";
            // 
            // btnCalculateResult
            // 
            this.btnCalculateResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculateResult.Location = new System.Drawing.Point(48, 367);
            this.btnCalculateResult.Name = "btnCalculateResult";
            this.btnCalculateResult.Size = new System.Drawing.Size(161, 37);
            this.btnCalculateResult.TabIndex = 6;
            this.btnCalculateResult.Text = "Calculate Result";
            this.btnCalculateResult.UseVisualStyleBackColor = false;
            this.btnCalculateResult.Click += new System.EventHandler(this.btnCalculateResult_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(52, 433);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersWidth = 51;
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(464, 210);
            this.dgvResult.TabIndex = 7;
            // 
            // btnDataToCSV
            // 
            this.btnDataToCSV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDataToCSV.Location = new System.Drawing.Point(58, 675);
            this.btnDataToCSV.Name = "btnDataToCSV";
            this.btnDataToCSV.Size = new System.Drawing.Size(151, 37);
            this.btnDataToCSV.TabIndex = 8;
            this.btnDataToCSV.Text = "Save Data To CSV";
            this.btnDataToCSV.UseVisualStyleBackColor = false;
            this.btnDataToCSV.Click += new System.EventHandler(this.btnDataToCSV_Click);
            // 
            // StudentResultManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 752);
            this.Controls.Add(this.btnDataToCSV);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.btnCalculateResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMarks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtRollNumber);
            this.Name = "StudentResultManagementForm";
            this.Text = "StudentResultManagementSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRollNumber;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculateResult;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button btnDataToCSV;
    }
}

