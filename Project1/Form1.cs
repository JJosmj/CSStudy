namespace Project1
{
    public partial class Form1 : Form
    {
        private int savedNum = 0;
        private int operate = 0; // 1:Plus, 2:Minus, 3:Multi, 4:Div
        private bool newInput = true;

        public Form1()
        {
            InitializeComponent();
        }
        private void btnEq_Click(object sender, EventArgs e)
        {
            int finalNum = int.Parse(txtResult.Text);

            int result = 0;

            switch (operate)
            {
                case 1:
                    result = savedNum + finalNum;
                    break;

                case 2:
                    result = savedNum - finalNum;
                    break;

                case 3:
                    result = savedNum * finalNum;
                    break;

                case 4:
                    result = savedNum / finalNum;
                    break;
            }

            txtResult.Text = result.ToString();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //Console.WriteLine("Tag : " + btn.Tag);
            string strNum = btn.Tag.ToString();

            if (newInput)
            {
                if (strNum != "0")
                {
                    txtResult.Text = strNum;
                    newInput = false;
                }
            }
            else
            {
                txtResult.Text += strNum;
            }
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            operate = int.Parse(btn.Tag.ToString());
            savedNum = int.Parse(txtResult.Text);
            newInput = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            newInput = true;
        }
    }
}