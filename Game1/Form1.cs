using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class Form1 : Form
    {
        const int WTileSize = 16;
        const int HTileSize = 9;
        const string Title = "푸시푸시 [Stage: ";

        int Stage;
        bool EndGame;
        int keyCount;

        Image Human;
        Image HumanF;
        Image HumanB;
        Image HumanL;
        Image HumanR;

        Image Wall;
        Image Road;
        Image Box;
        Image Dot;

        int WTile;  // 가로 타일
        int HTile;  // 세로 타일

        int XHuman;
        int YHuman;
        int XHumanOld;
        int YHumanOld;

        char[][] MapReal;

        string[,] Map = {
                                 { "################",  // 0
                                   "##   B.       ##",  // 1
                                   "##    ## #  ####",  // 2
                                   "## #  ## # #####",  // 3
                                   "##    ## #  ####",  // 4
                                   "### ####    ####",  // 5
                                   "###         ####",  // 6
                                   "###   @ B.  ####",  // 7
                                   "################"   // 8
                                },
                                {
                                 "################",  // 0
                                 "##            ##",  // 1
                                 "##    ##B#  ####",  // 2
                                 "## #  ## # #####",  // 3
                                 "##   .## #  ####",  // 4
                                 "### ####    ####",  // 5
                                 "###  @      ####",  // 6
                                 "###       B.####",  // 7
                                 "################"   // 8
                                },
                                {
                                 "################",  // 0
                                 "##  .         ##",  // 1
                                 "##  ##  # ## ###",  // 2
                                 "##        B  ###",  // 3
                                 "##   ###    ####",  // 4
                                 "###   @#    ##.#",  // 5
                                 "###  ##     ##B#",  // 6
                                 "###            #",  // 7
                                 "################"   // 8
                                },
                                {
                                 "################",  // 0
                                 "##  B         ##",  // 1
                                 "##   # # #.# ###",  // 2
                                 "##        B  ###",  // 3
                                 "#######     ####",  // 4
                                 "###   B     ##.#",  // 5
                                 "###  ##  @  ## #",  // 6
                                 "###.           #",  // 7
                                 "################"   // 8
                                }
                                };


        public Form1()
        {
            InitializeComponent();

            Text = Title;
            Stage = 0;

            HumanF = new Bitmap(Properties.Resources.HumanF);
            WTile = HumanF.Width; //이미지의 가로 세로 크기 추출
            HTile = HumanF.Height; //이 두줄덕분에 크기가 바껴도 코드를 크게 수정하지않아도된다
            ClientSize = new Size(WTileSize * WTile, HTileSize * HTile);
            // ClientSize가 타입이 Size형이니까 Size의 크기를 ()안에 적어준다.
            // ClientSize를 치고 컨트롤을 누른상태로 ClientSize를 눌러준다.
            // 이런 키워드를 추적해서 using System의 형태를 알아줘야한다.

            HumanB = new Bitmap(Properties.Resources.HumanB);
            HumanL = new Bitmap(Properties.Resources.HumanL);
            HumanR = new Bitmap(Properties.Resources.HumanR);

            Wall = new Bitmap(Properties.Resources.Wall);
            Road = new Bitmap(Properties.Resources.Road);
            Box = new Bitmap(Properties.Resources.Box);
            Dot = new Bitmap(Properties.Resources.Dot);

            XHuman = 0;
            YHuman = 0;

            LoadMap();

        }

        private void LoadMap()
        {
            MapReal = new char[HTileSize][];
            for (int i = 0; i < HTileSize; i++)
            {
                MapReal[i] = Map[Stage, i].ToCharArray();
            }
            keyCount = 0; //판이 넘어갈때 키 누른 횟수 초기화
            Human = HumanF;
            Refresh();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            EndGame = true; // 게임종료 조건
            Image Temp = Wall;
            for(int j = 0;j < HTileSize; ++j)
            {
                for(int i = 0;i < WTileSize; ++i)
                {
                    switch (MapReal[j][i])
                    {
                        case '#':
                            Temp = Wall;
                            break;
                        case 'B':
                            Temp = Box;
                            if ('.' != Map[Stage,j][i]) // 박스가 .에 갔을때 종료
                            {
                                EndGame = false;
                            }
                            break;
                        case '.':
                            Temp = Dot;
                            break;
                        case ' ':
                            Temp = Road;
                            break;
                        case '@':
                            Temp = Human;
                            XHuman = i;
                            YHuman = j;
                            break;
                    }
                    e.Graphics.DrawImage(Temp, WTile * i, HTile * j);
                }
            }
            Text = Title + (Stage + 1) + "] [" + keyCount + "]";  // 키로 이동할때마다 제목에 카운트해주는 구문
        }
        
        private void Move()
        {
            if('#' == MapReal[YHuman][XHuman]) // 벽에 부딪히면 못움직임
            {
                return;
            }
            else if ('B' == MapReal[YHuman][XHuman]) //박스를 만나면 미는것
            {
                if ('#' == MapReal[YHuman * 2 - YHumanOld][XHuman * 2 - XHumanOld])//박스가 벽에 부딪힐때
                { return; }    
                
                if ('B' == MapReal[YHuman * 2 - YHumanOld][XHuman * 2 - XHumanOld]) // 상자가 2개가 겹쳤을때 안움직이게하는코드
                { return; }    // return이 들어가면 이미 분리된거나 다름없기때문에 else if를 굳이 붙이지않아도된다.(else if랑 똑같다)
            
                MapReal[YHuman * 2 - YHumanOld][XHuman * 2 - XHumanOld] = 'B';// 좌항은 좌표를뜻함. 박스가 캐릭터를만나면 이동되는 코드
            }
            if ('.' == Map[Stage, YHumanOld][XHumanOld])
            {
                MapReal[YHumanOld][XHumanOld] = '.';
            }
            else
            {
                MapReal[YHumanOld][XHumanOld] = ' ';
            }
            MapReal[YHuman][XHuman] = '@'; //박스자리로 캐릭터 이동

            ++keyCount;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            YHumanOld = YHuman;
            XHumanOld = XHuman;

            switch(e.KeyCode)
            {
                case Keys.F5:
                    if(DialogResult.Yes == MessageBox.Show("다시 시작할까여?","확인",MessageBoxButtons.YesNo))
                    { LoadMap(); }
                    return;
                case Keys.Left:
                    --XHuman;
                    Human = HumanL;
                    break;
                case Keys.Right:
                    ++XHuman;
                    Human = HumanR;
                    break;
                case Keys.Up:
                    --YHuman;
                    Human = HumanB;
                    break;
                case Keys.Down:
                    ++YHuman;
                    Human = HumanF;
                    break;
                default:
                    return;
            }
            Move();
            Refresh();
            if(EndGame == true)
            {
                ++Stage;
                if(Stage == Map.Length/HTileSize)
                {
                    MessageBox.Show("게임 종료", "알림", MessageBoxButtons.OK);
                    Environment.Exit(0);
                }
                MessageBox.Show("다음판으로 이동", "알림", MessageBoxButtons.OK);
                LoadMap();
            }
        }
    }
}

