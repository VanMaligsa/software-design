namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void btnCalculateFibonacci_Click_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int n) && n >= 0)
            {
                lblResult.Text = $"Fibonacci({n}) = {Fibonacci(n)}";
            }

            else
            {
                lblResult.Text = $"Invalid!";
            }
        }
    }
}
