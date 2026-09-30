using TextBookSupport.Models;

namespace TextBookSupport
{
    public partial class Form1 : Form
    {
        TextbookSupportContext context = new TextbookSupportContext();
        public Form1()
        {
            InitializeComponent();
            GetStudents();
            GetTextbooks();
        }

        public void GetStudents()
        {
            //listStudent.DataSource = context.Students.ToList();

            studentBindingSource.DataSource = context.Students.Where(x => x.Name.Contains(studentTbx.Text)).ToList();
        }

        public void GetTextbooks()
        {
            textbookBindingSource.DataSource = context.Textbooks.Where(x => x.Title.Contains(booksTbx.Text)).ToList();
        }

        public void GetOrders()
        {
            var student = (Student)studentBindingSource.Current;

            if (student != null)
            {
                studentOrderBindingSource.DataSource = context.Orders.Where(x => x.StudentFk == student.StudentId).Select(x => new StudentOrder
                {
                    OrderSk = x.OrderSk,
                    Title = x.TextbookFkNavigation!.Title
                }).ToList();
            }
        }

        private void studentTbx_TextChanged(object sender, EventArgs e)
        {
            GetStudents();
        }

        private void booksTbx_TextChanged(object sender, EventArgs e)
        {
            GetTextbooks();
        }

        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            GetOrders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student? student = studentBindingSource.Current as Student;
            Textbook? textbook = textbookBindingSource.Current as Textbook;

            if (student != null)
            {
                Order order = new Order
                {
                    StudentFk = student.StudentId,
                    TextbookFk = textbook?.TextbookId ?? 0
                };
                context.Orders.Add(order);
                context.SaveChanges();
                GetOrders();
            }
        }
    }
    public class StudentOrder
        {
            public int OrderSk { get; set; }
            public string? Title { get; set; }
        }
}
