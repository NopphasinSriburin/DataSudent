using System.Diagnostics;

namespace DST
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<double> gardes = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void N_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = this.name.Text;
            String id = this.Id.Text;
            String birth = this.date.Text;
            String height = this.height.Text;
            String garde = this.gards.Text;
            String field = this.saka.Text;

            int iBirth = Int32.Parse(birth);
            double iHeight = double.Parse(height);
            double iGarde = double.Parse(garde);

            Student newStudent = new Student(name, id, iBirth, iHeight, iGarde, field);
            this.students.Add(newStudent);
            this.gardes.Add(iGarde);

            this.name.Text = "";
            this.Id.Text = "";
            this.date.Text = "";
            this.height.Text = "";
            this.gards.Text = "";
            this.saka.Text = "";

            BindingSource source = new BindingSource();
            source.DataSource = this.students;
            this.dataGridView1.DataSource = source;

            Int32 StdCount = students.Count;
            double MostGrade = gardes.Max();
            Double LeastGrade = gardes.Min();

            Maxgards.Text = LeastGrade.ToString();
            Mingards.Text = MostGrade.ToString();
            somthing.Text = StdCount.ToString();
        }

        private void Check_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Maxgards_TextChanged(object sender, EventArgs e)
        {

        }
    }
}