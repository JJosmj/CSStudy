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
           DialogResult res=  MessageBox.Show("�ΰ��� ��ư�� ���� �޽����ڽ�", "��ư3 Ŭ��", MessageBoxButtons.YesNo);

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
            MessageBox.Show("����� ������ �ִ� �޽����ڽ�", "��ư2 Ŭ��");
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("�⺻ �޼��� �ڽ�");

            Console.WriteLine("��ư1 Ŭ��");
        }

        private void btnUid_Click(object sender, EventArgs e)
        {
          string uid = txtUid.Text;
            lbUid.Text ="���: " +uid;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lbName.Text = "���: " + name;
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            string hp = txtHp.Text;
            lbHp.Text = "���: " + hp;
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

            lbFruitResult.Text = "���: " +string.Join(", ",fruits);
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

            lbColorResult.Text = "���: " + string.Join(",", color);
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