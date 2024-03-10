using Lab1;

namespace Lab1Gui
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

        private void RunButton_Click(object sender, EventArgs e)
        {
            int n = ItemsNum.Text == "" ? 0 : int.Parse(ItemsNum.Text);
            int seed = SeedVal.Text == "" ? 0 : int.Parse(SeedVal.Text);
            int capacity = CapacityVal.Text == "" ? 0 : int.Parse(CapacityVal.Text);
            Problem problem = new Problem(n, seed);
            Result result = problem.solve(capacity);
            Display.Text = problem.listItemsText();
            ResultBox.Text = result.printResult();
        }
    }
}
