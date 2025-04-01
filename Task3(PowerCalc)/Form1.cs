using System.Reflection.Metadata.Ecma335;

namespace Task3_PowerCalc_
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

        public int PowerCalculation(int x, int n)
        {
            if (n == 0) return 1;
            return x * PowerCalculation(x, n - 1);
        }

        private void btnCalcuate_Click_Click(object sender, EventArgs e)
        {
            int BaseNum = int.Parse(txtBaseInput.Text);
            int Exponent = int.Parse(txtExpoInput.Text);
            int result = PowerCalculation(BaseNum, Exponent);
            lblResult.Text = $"Result: {result}";
        }
    }
}
