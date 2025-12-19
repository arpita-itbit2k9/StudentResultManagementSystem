using StudentResultManagementSystem.BusinessLogic.Services;
using StudentResultManagementSystem.Contracts.Interfaces;
using StudentResultManagementSystem.Contracts.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace StudentResultManagementSystem
{
    public partial class StudentResultManagementForm : Form
    {
       
        private readonly IResultService _resultService;
        private List<SubjectMarks> _marksList;
        private StudentResult _studentResult;

        public StudentResultManagementForm(IResultService resultService)
        {
            InitializeComponent();

            this._resultService = resultService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupMarksGrid();
            AddData();
        }

        private void AddData()
        {
            dgvMarks.Rows.Clear();

            dgvMarks.Rows.Add("Maths", 100, 60);
            dgvMarks.Rows.Add("Science", 100, 75);
            dgvMarks.Rows.Add("English", 100, 95);
            txtRollNumber.Text = "101";
            txtStudentName.Text = "John Doe";
        }

        private void SetupMarksGrid()
        {
            dgvMarks.Columns.Clear();

            dgvMarks.Columns.Add("SubjectName", "Subject");
            dgvMarks.Columns.Add("MaxMarks", "Max Marks");
            dgvMarks.Columns.Add("Marks", "Marks Obtained");
        }

        private void btnCalculateResult_Click(object sender, EventArgs e)
        {
            SetupResultGrid();

        }

        private void SetupResultGrid()
        {
           _studentResult =  _resultService.GenerateResult(new Student
            {
                RollNumber = Int32.Parse(txtRollNumber.Text),
                Name = txtStudentName.Text
            }, Marks());

            dgvResult.Columns.Clear();
            dgvResult.Rows.Clear();
            dgvResult.Columns.Add("Field", "Field");
            dgvResult.Columns.Add("Value", "Value");
            dgvResult.Rows.Add(nameof(_studentResult.TotalMarks), _studentResult.TotalMarks.ToString());
            dgvResult.Rows.Add(nameof(_studentResult.ObtainedMarks), _studentResult.ObtainedMarks.ToString());
            dgvResult.Rows.Add(nameof(_studentResult.Percentage).ToString(), _studentResult.Percentage.ToString("0.00"));
            dgvResult.Rows.Add(nameof(_studentResult.Grade).ToString(), _studentResult.Grade);

        }

        private List<SubjectMarks> Marks()
        {
             _marksList = new List<SubjectMarks> {};
            
                foreach( DataGridViewRow row in dgvMarks.Rows)
                {

                    if (row.IsNewRow) continue;
                    SubjectMarks subjectMarks = new SubjectMarks
                        {
                            SubjectName = row.Cells["SubjectName"].Value.ToString(),
                            MaxMarks = Int32.Parse(row.Cells["MaxMarks"].Value.ToString()),
                            Marks = Int32.Parse(row.Cells["Marks"].Value.ToString())
                        };
                           _marksList.Add(subjectMarks);
                }

                return _marksList;

        }

        private void btnDataToCSV_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a file";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Multiselect = false;
                openFileDialog.CheckFileExists = false;   
                openFileDialog.CheckPathExists = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }


           bool resultSuccess =  _resultService.SaveResult(filePath, _studentResult, _marksList);
            
             if(resultSuccess)
            {
                MessageBox.Show("CSV Data saved successfully");
                this.Close();
            }
           

        }
    }
}
