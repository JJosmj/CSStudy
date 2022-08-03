namespace Project3
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Pen pen;
        private Brush wbrush, bbrush;

        private int margin = 40;
        private int sizeNun = 30;
        private int sizeDol = 28;
        private int sizeH = 10;

        private bool isBlack = true;
        enum STONE {none,black,white }

        STONE[,] dataSet = new STONE[19, 19];


        public Form1()
        {
            InitializeComponent();

            //바둑판 색
            g= this.CreateGraphics();
            pen = new Pen(Color.Black);
            wbrush = new SolidBrush(Color.White);
            bbrush = new SolidBrush(Color.Black);

            this.BackColor = Color.Orange;
            this.ClientSize = new Size(2*margin+18*sizeNun, 2*margin+18*sizeNun);

        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            for (int z = 0; z < 19; z++)
            {
                //가로
                g.DrawLine(pen, new Point(margin, margin + sizeNun * z), new Point(margin + 18 * sizeNun, margin + sizeNun * z));
                //세로
                g.DrawLine(pen, new Point(margin + sizeNun * z,margin), new Point(margin + sizeNun * z, margin + 18 * sizeNun));
            }
                

        }
        


            private void From1_MouseDown(object sende,MouseEventArgs e)
        {
            int x = (e.X-margin+sizeNun/2)/sizeNun;
            int y = (e.Y - margin + sizeNun / 2)/ sizeNun;

            // Console.WriteLine($"x:{x},y:{y}");

            Rectangle dol = new Rectangle(margin + sizeNun * x - sizeNun / 2
                                        , margin + sizeNun * y - sizeNun / 2,
                                          sizeDol,sizeDol);

            //돌이 놓여있는지 확인
            if (dataSet[x,y]!=STONE.none)
            {
                MessageBox.Show("이미 돌이 놓여 있습니다");
                return;
            }

            //검은돌,흰돌 그리기
            if(isBlack)
            {
                g.FillEllipse(bbrush, dol);
                dataSet[x, y] = STONE.black;
                isBlack = false;
            }
            else
            {
                g.FillEllipse(wbrush, dol);
                dataSet[x, y] = STONE.white;
                isBlack=true;
            }

            //오목 판정
            CheckOmok(x, y);

        }
        public void CheckOmok(int x, int y)
        {
            int count = 1;

            //오른쪽
            for(int i=x+1; i<x+5; i++)
            {
                if (dataSet[x, y] == dataSet[i,y])
                {
                    count++;
                   
                }
                else
                {
                    break;
                }
            }
            CheckCountResult(count);
            //왼쪽
            for (int i = x-1; i >x-5; i--)
            {
                if (dataSet[x, y] == dataSet[i, y])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            CheckCountResult(count);
            count = 1;
            //위
            for (int i = y +1; i< y+ 5; i++)
            {
                if (dataSet[x, y] == dataSet[x, i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            CheckCountResult(count);
            //아래
            for (int i = y- 1; i > y- 5; i--)
            {
                if (dataSet[x, y] == dataSet[x, i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            
            CheckCountResult(count);
            count = 1;
            //11
            for (int i = x - 1, j=y-1; i>=0 && j>= 0; i--,j--)
            {
                if (dataSet[x, y] == dataSet[i, j])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            CheckCountResult(count);
            //4
            for (int i = x + 1, j = y + 1; i < 19 && j < 19; i++, j++)
            {
                if (dataSet[x, y] == dataSet[i, j])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            CheckCountResult(count);
            count = 1;
            //1
            for (int i = x + 1, j = y - 1; i < 19 && j >= 0; i++, j--)
            {
                if (dataSet[x, y] == dataSet[i, j])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            CheckCountResult(count);
            //7
            for (int i = x - 1, j = y + 1; i >= 0 && j < 19; i--, j++)
            {
                if (dataSet[x, y] == dataSet[i, j])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }            
        }

        public void CheckCountResult(int count)
        {
            if (count>=5)
            {
             DialogResult result  = MessageBox.Show("오목","확인",MessageBoxButtons.YesNo);
                if(result==DialogResult.Yes)
                {
                    NewGame();
                    return;
                }
                else
                {
                    this.Close();
                }
            }
        }

        public void NewGame()
        {
            //화면 갱신
            this.Invalidate();

            //dataSet 초기화
            for(int x = 0; x < 19; x++)
            {
                for(int y = 0; y < 19; y++)
                {
                    dataSet[x, y] = STONE.none;
                }
            }

            //검은돌 시작
            isBlack = true;

        }


    }
}