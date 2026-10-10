
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentGradeManager
{
    public partial class Form1 : Form
    {
        // ENUM: Represents the student result.
        private enum GradeStatus
        {
            Pass,
            Fail
        }

        // STRUCT: Stores information about a student.
        private struct Student
        {
            public string Id;
            public string Name;
            public double[] Scores;

            public Student(string id, string name, double[] scores)
            {
                Id = id;
                Name = name;
                Scores = scores;
            }

            public double Average
            {
                get
                {
                    double total = 0;

                    foreach (double score in Scores)
                    {
                        total += score;
                    }

                    return total / Scores.Length;
                }
            }

            public GradeStatus Status
            {
                get
                {
                    return Average >= 60
                        ? GradeStatus.Pass
                        : GradeStatus.Fail;
                }
            }
        }

        // LIST: Stores all students.
        private readonly List<Student> students = new List<Student>();

        // DICTIONARY: Finds students using their IDs.
        private readonly Dictionary<string, Student> studentLookup =
            new Dictionary<string, Student>(
                StringComparer.OrdinalIgnoreCase);

        public Form1()
        {
            InitializeComponent();

            ConfigureTable();

            btnAdd.Click += btnAdd_Click;
            btnSearch.Click += btnSearch_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            dgvStudents.CellClick += dgvStudents_CellClick;
        }

        // Configure the DataGridView.
        private void ConfigureTable()
        {
            dgvStudents.Columns.Clear();

            dgvStudents.Columns.Add("colId", "Student ID");
            dgvStudents.Columns.Add("colName", "Full Name");
            dgvStudents.Columns.Add("colMath", "Math");
            dgvStudents.Columns.Add("colEnglish", "English");
            dgvStudents.Columns.Add("colScience", "Science");
            dgvStudents.Columns.Add("colAverage", "Average");
            dgvStudents.Columns.Add("colStatus", "Status");

            dgvStudents.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvStudents.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvStudents.MultiSelect = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.RowHeadersVisible = false;
        }

        // ADD STUDENT
        private void btnAdd_Click(object? sender, EventArgs e)
        {
            string id = txtStudentId.Text.Trim();
            string name = txtStudentName.Text.Trim();

            if (id == "" || name == "")
            {
                MessageBox.Show(
                    "Please enter Student ID and Full Name.");
                return;
            }

            if (studentLookup.ContainsKey(id))
            {
                MessageBox.Show(
                    "This Student ID already exists.");
                return;
            }

            // ARRAY: Stores scores for three subjects.
            double[] scores =
            {
                (double)nudMath.Value,
                (double)nudEnglish.Value,
                (double)nudScience.Value
            };

            Student student = new Student(id, name, scores);

            students.Add(student);
            studentLookup.Add(id, student);

            RefreshTable();
            ClearInputs();

            MessageBox.Show("Student added successfully!");
        }

        // SEARCH STUDENT
        private void btnSearch_Click(object? sender, EventArgs e)
        {
            string id = txtStudentId.Text.Trim();

            if (studentLookup.TryGetValue(id, out Student student))
            {
                DisplayStudent(student);
                SelectStudentRow(student.Id);

                MessageBox.Show(
                    $"Name: {student.Name}\n" +
                    $"Average: {student.Average:F2}\n" +
                    $"Status: {student.Status}");
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
        }

        // DELETE STUDENT
        private void btnDelete_Click(object? sender, EventArgs e)
        {
            string id = txtStudentId.Text.Trim();

            if (!studentLookup.TryGetValue(id, out Student student))
            {
                MessageBox.Show("Student not found.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Do you want to delete {student.Name}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                studentLookup.Remove(id);

                students.RemoveAll(
                    s => string.Equals(
                        s.Id,
                        id,
                        StringComparison.OrdinalIgnoreCase));

                RefreshTable();
                ClearInputs();

                MessageBox.Show("Student deleted successfully!");
            }
        }

        // CLEAR INPUTS
        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtStudentId.Clear();
            txtStudentName.Clear();

            nudMath.Value = 0;
            nudEnglish.Value = 0;
            nudScience.Value = 0;

            txtStudentId.Focus();
        }

        // DISPLAY STUDENT INFORMATION
        private void DisplayStudent(Student student)
        {
            txtStudentId.Text = student.Id;
            txtStudentName.Text = student.Name;

            nudMath.Value = (decimal)student.Scores[0];
            nudEnglish.Value = (decimal)student.Scores[1];
            nudScience.Value = (decimal)student.Scores[2];
        }

        // REFRESH THE TABLE
        private void RefreshTable()
        {
            dgvStudents.Rows.Clear();

            foreach (Student student in students)
            {
                dgvStudents.Rows.Add(
                    student.Id,
                    student.Name,
                    student.Scores[0],
                    student.Scores[1],
                    student.Scores[2],
                    student.Average.ToString("F2"),
                    student.Status.ToString()
                );
            }

            dgvStudents.ClearSelection();
        }

        // SELECT STUDENT IN THE TABLE
        private void SelectStudentRow(string id)
        {
            dgvStudents.ClearSelection();

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                string rowId =
                    row.Cells["colId"].Value?.ToString() ?? "";

                if (string.Equals(
                    rowId,
                    id,
                    StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        // CLICK A STUDENT ROW TO VIEW DETAILS
        private void dgvStudents_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string id =
                dgvStudents.Rows[e.RowIndex]
                    .Cells["colId"].Value?.ToString() ?? "";

            if (studentLookup.TryGetValue(id, out Student student))
            {
                DisplayStudent(student);
            }
        }
    }
}
