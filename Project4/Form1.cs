namespace Project4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Brush rBrush = new SolidBrush(Color.Red);
        Brush blBrush = new SolidBrush(Color.Orange);
        Brush baBrush = new SolidBrush(Color.HotPink);
        Pen Pen = new Pen(Color.Black);

        Rectangle racket = new Rectangle();
        Rectangle[] blocks= new Rectangle[100];
        Rectangle ball = new Rectangle();

        int nBlock = 20;

        int racketW = 50;
        int racketH = 10;
        int racketY = 480;

        int blockW = 30;
        int blockH = 20;
        int blockY= 60;

        int ballW = 10;
        int ballH = 10;

        double slope = 0; //공 기울기
        double dir = 0; //공이 아래,위로 향하는 방향 여부

        bool[] blockVisible = new bool[100];

        Random ran = new Random();

        public Form1()
        {
            InitializeComponent();

            //폼 사이즈
            this.ClientSize = new Size(300, 500);
            this.Text = "벽돌깨기 v1.0";
            

            //그래픽 객체
            g = this.CreateGraphics();

            //블럭 초기화
            InitBlock();

            //라켓 초기화
            InitRacket();

            //공 초기화
            InitBall();


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //벽돌 그리기
            for(int i = 0;i<nBlock;i++)
            {
                if (blockVisible[i])
                {
                    g.FillRectangle(blBrush, blocks[i]);
                }
            }


            //라켓 그리기
            g.FillRectangle(rBrush, racket);
            
            //공 그리기
            g.FillEllipse(baBrush, ball);
            g.DrawEllipse(Pen, ball);
        }

        public void InitBlock() 
        {
            for (int i =0;i<nBlock;i++)
            {
                blocks[i] = new Rectangle(blockW * (i % 10), blockY + blockH * (i/10), blockW - 1, blockH - 1);

                blockVisible[i] = true;
            }        
            
        }
        public void InitRacket() 
        {
            racket.X = this.Width/2 - racketW/2;
            racket.Y = racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }
        public void InitBall() 
        { 
            ball.X = this.Width/2 - ballW/2;
            ball.Y = ballH + blockY *2;
            ball.Width = ballW;
            ball.Height = ballH;

            slope = ran.Next(1,20) / 10.0;

            if(ran.Next(2)%2 ==1)
            {
                slope = -slope;
            }
            dir = 1;
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("Tick!");

            double dx = ballW / slope;
            double dy = Math.Abs(ballH * slope) * dir;

            int x = (int)dx;
            int y = (int)dy;

            ball.X += x;
            ball.Y += y;

            //벽 충돌
            if(ball.X<=0 || ball.X>= this.Width - ballW)
            {

                slope = -slope;
            }
            // 라켓 충돌
            if(ball.Y<0 || racket.IntersectsWith(ball))
            {
                dir = -dir;
            }
            //벽돌 충돌
            for(int i = 0; i < nBlock; i++)           
            {
                if (ball.IntersectsWith(blocks[i]))
                {
                    dir *= -1;
                    blockVisible[i] = false;
                }
            }

            //공을 놓쳤을때
            if(ball.Y>this.Height)
            {
                myTimer.Stop();

                MessageBox.Show("다시 시작하시겠습니까?","확인",MessageBoxButtons.YesNo);
                if(DialogResult == DialogResult.Yes)
                {
                    InitBlock();
                    InitBall();
                    InitRacket();

                    myTimer.Start();
                }
                else
                {
                    this.Close();
                }
            }

            //모든 블럭 파괴시


            //다시그리기(OnPaint 호출)
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                racket.X -= 10;

                
            }
            else if(e.KeyCode == Keys.Right)
            {
                racket.X += 10;
              
            }
        }

        private void 다시시작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myTimer.Stop();

            MessageBox.Show("다시 시작하시겠습니까?", "확인", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                InitBlock();
                InitBall();
                InitRacket();

                myTimer.Start();
            }
        }
    }
}