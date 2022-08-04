namespace Ch11
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

        private void btn6_Click(object sender, EventArgs e)
        {
           DialogResult res=  MessageBox.Show("두개의 버튼을 갖는 메시지박스", "버튼3 클릭", MessageBoxButtons.YesNo);

            if(res == DialogResult.Yes)
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("No");
            }

        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("제목과 내용이 있는 메시지박스", "버튼2 클릭");
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("기본 메세지 박스");

            Console.WriteLine("버튼1 클릭");
        }

        private void btnUid_Click(object sender, EventArgs e)
        {
          string uid = txtUid.Text;
            lbUid.Text ="결과: " +uid;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lbName.Text = "결과: " + name;
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            string hp = txtHp.Text;
            lbHp.Text = "결과: " + hp;
        }

        private void btnFurit_Click(object sender, EventArgs e)
        {
            CheckBox[] chkFruits = { chkFruit1, chkFruit2, chkFruit3, chkFruit4, chkFruit5 };
            List<string> fruits = new List<string>();

            foreach(CheckBox chk in chkFruits)
            {
                if(chk.Checked)
                {
                    fruits.Add(chk.Text);
                }
            }

            lbFruitResult.Text = "결과: " +string.Join(", ",fruits);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            CheckBox[] chkColor = { chkColor1, chkColor2, chkColor3, chkColor4, chkColor5 };
            List<string> color = new List<string>();

            foreach(CheckBox chk in chkColor)
            {
                if(chk.Checked)
                {
                    color.Add(chk.Text);
                }
            }

            lbColorResult.Text = "결과: " + string.Join(",", color);
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}