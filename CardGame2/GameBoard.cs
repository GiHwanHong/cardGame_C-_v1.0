using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using cardGame;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Timers;

namespace CardGame2
{
    public  partial class GameBoard : MaterialForm
    {
        private string _gameUser = "";
        private string _gameLevel= "";
        private int _gameScore = 0;   
        private string _gameExecuteTime = "";
        
        // 카드를 보여주는 시간결정에 사용하는 변수.
        private int _showCardTime = 0;              

        // 게임시간을 계산하기 위해 사용되는 변수.
        private System.Timers.Timer gameTimer;
        private int _gameHour, _gameMinute, _gameSecond;

        // DB에 연결에 사용할 변수.
        DBConnection dbConn = DBConnection.GetInstance();

        // 카드를 무작위로 섞기위해 사용할 변수.
        Random rCard = new Random();

        // 카드의 이미지를 저장하는 것과 카드 클릭횟수를 저장하기 위해 사용하는 변수.
        Dictionary<object, Image> dicImages = new Dictionary<object, Image>();
        private int _dicClickCnt = 0;        
        
        // 이미지를 나타낼 수 있는 PictureBox 변수.
        PictureBox pendingImage1;           
        PictureBox pendingImage2;

        SoundPlayer successSound = new SoundPlayer(CardGame2.Properties.Resources.success);
        SoundPlayer failSound = new SoundPlayer(CardGame2.Properties.Resources.fail);

        // 게임 실행 중 맞춘 카드를 기록하기위해 사용할 변수.
        List<object> successTagList = new List<object>(); 

        public GameBoard()
        {
            GameExecuteInitalize();
            MaterialDesignForm();
            InitializeComponent();
        }

        private void GameExecuteInitalize()
        {
            // 게임이 처음 실행 되기 전 사용자 입력과 게임단계를 설정.
            GameUser gUser = new GameUser();
            gUser.ShowDialog();
            gUser.Close();

            GameLevel gLevel = new GameLevel();
            gLevel.ShowDialog();
            gLevel.Close();

            _gameUser = gUser.UserName;
            _gameLevel = gLevel.LevelName;

            gUser = null;
            gLevel = null;

            switch (_gameLevel)
            {
                // 단계를 선택한 것에 따른 카드 보여주기 시간을 결정.
                case "초급":
                    _showCardTime = 5000;
                    break;
                case "중급":
                    _showCardTime = 4000;
                    break;
                case "고급":
                    _showCardTime = 3000;
                    break;
            }

            for (int i = 1; i < 9; i++)
            {
                var image = (Image)Properties.Resources.ResourceManager.GetObject("movie" + i);
                dicImages.Add(i, image);
            }
        }

        private void gameBoard_Load(object sender, EventArgs e)
        {
            this.Text += _gameUser;
            gameTimer = new System.Timers.Timer();
            gameTimer.Interval = 1000;               
            gameTimer.Elapsed += OnTimeEvent;

            _dicClickCnt = dicImages.Count;

            successTagList.Clear();         

            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = false;
            }
           
            int[] iCard = new int[16];
            int randNumber, temp;

            for (int i = 0; i < 16; i++)
            {
                iCard[i] = i + 1;
            }

            for (int i = 0; i < 16; i++)
            {
                randNumber = rCard.Next(0, 15);
                
                temp = iCard[randNumber];
                iCard[randNumber] = iCard[i];
                iCard[i] = temp;
            }

            if (_showCardTime != 0)
            {
                // 카드게임을 시작할 때 보여주는 시간을 결정하는 것.
                gameInitPreviewTimer.Interval = _showCardTime;
                gameInitPreviewTimer.Start();

                int iCnt = 0;
                foreach (PictureBox picture in CardsHolder.Controls)
                {
                    iCard[iCnt] = iCard[iCnt] % 8 + 1;
                    picture.Tag = iCard[iCnt];
                    picture.Image = dicImages[picture.Tag];
                    iCnt++;
                }
            }
        }

        private void gameInitPreviewTimer_Tick(object sender, EventArgs e)
        {
            // 맨 처음, 카드를 보여주는 시간이 끝나면 카드의 상태가 front로 변경됨.
            gameInitPreviewTimer.Stop();

            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.front;
            }

            gameTimer.Start();  // 게임시작 후 시간을 누적하는 타이머
        }

        private void gameCardStatusTimer_Tick(object sender, EventArgs e)
        {
            // 힌트 버튼 클릭 후 다시 카드의 상태를 front.png 파일로 변경.
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                if (successTagList.Contains(picture.Tag))
                {
                    continue;
                }
                picture.Image = Properties.Resources.front;
            }
            gameCardStatusTimer.Stop();
        }

        private void gameCardIncorrectTimer_Tick(object sender, EventArgs e)
        {
            // 틀렸을 경우에 원래 이미지(front.png)를 보여주도록 처리.
            gameCardIncorrectTimer.Stop();

            pendingImage1.Image = Properties.Resources.front;
            pendingImage2.Image = Properties.Resources.front;
            pendingImage1 = null;
            pendingImage2 = null;
        }

        private void gameCardCorrectTimer_Tick(object sender, EventArgs e)
        {
            // 카드가 일치했을 때 처리하는 타이머.
            gameCardCorrectTimer.Stop();

            _dicClickCnt -= 1;
            pendingImage1.Enabled = true;
            pendingImage2.Enabled = true;
            pendingImage1 = null;
            pendingImage2 = null;

            if (_dicClickCnt == 0)
            {  
                // 카드가 모두 일치됫을 때 처리.
                gameTimer.Stop();
                _gameExecuteTime = lblGameTime.Text;
                dbConn.Insert(_gameUser, _gameLevel, _gameScore, _gameExecuteTime); // insert 작업.

                GameRank gRank = new GameRank();
                gRank.ShowDialog();

                if (MessageBox.Show("다시 실행하시겠습니까?", "다시시도", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Visible = false;
                    lblScore.Text = "0";
                    lblGameTime.Text = string.Format("00:00:00");
                    foreach (PictureBox picture in CardsHolder.Controls)
                    {
                        picture.Click += card_Click;
                    }
                    new GameBoard();
                    //this.Activate();
                }
                else
                {
                    DisposeTimerThreads();   
                }
            }
        }

        private void gameBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // 폼 종료시 
                if (MessageBox.Show("종료하시겠습니까?", "종료메시지", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            // card Hint 
            gameCardStatusTimer.Start();
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                if (successTagList.Contains(picture.Tag))
                {
                    continue;
                }
                picture.Image = dicImages[picture.Tag];
            }

            // Hint를 사용했기 때문에 -10씩 감소.
            lblScore.Text = Convert.ToString(_gameScore > 0 ? _gameScore -= 10 : 0);
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {  
            if (MessageBox.Show("다시 실행하시겠습니까?", "다시시도", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ReStartGame();
                gameBoard_Load(sender, e);
                foreach (PictureBox picture in CardsHolder.Controls)
                {
                    picture.Click += card_Click;
                }
            }
        }

        private void card_Click(object sender, EventArgs e)
        {
            var card =  sender as PictureBox;

            // Case Choose Card 
            if (pendingImage1 == null)
            {   
                pendingImage1 = card;
                card.Image = dicImages[pendingImage1.Tag];
                return;
            }
            else if (pendingImage1 == card)
            {       
                // 카드를 두번클릭할 경우 처리.
                return;
            }
            else if (pendingImage2 == null)
            {
                pendingImage2 = card;
                card.Image = dicImages[pendingImage2.Tag];
            }

            // Card Control
            if(pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag.Equals(pendingImage2.Tag))         
                {   //  선택한 두개의 카드가 일치했을 때,
                    pendingImage1.Image = Properties.Resources.back;
                    pendingImage2.Image = Properties.Resources.back;

                    pendingImage1.Enabled = false;
                    pendingImage2.Enabled = false;

                    successTagList.Add(pendingImage1.Tag);     
                    // Tag 값이 같기 때문에 하나의 Tag 값만 넣는다.

                    // 점수가 0 이하로 떨어지지 않기 위한 처리.
                    lblScore.Text = Convert.ToString(_gameScore >= 0 || _gameScore < 0 ? _gameScore += 10 : _gameScore);
                    
                    pendingImage1.Click -= card_Click;
                    pendingImage2.Click -= card_Click;

                    successSound.Play();

                    gameCardCorrectTimer.Start();
                }
                else
                {
                    failSound.Play();

                    gameCardIncorrectTimer.Start();
                    lblScore.Text = Convert.ToString(_gameScore > 0 ? _gameScore -= 10 : _gameScore);
                }
            }
        }

        private void GameBoard_FormClosed(object sender, FormClosedEventArgs e)
        {   
            DisposeTimerThreads();
        }

        // 게임시간을 표시하기위한 계산 및 format setting
        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    _gameSecond += 1;
                    if (_gameSecond == 60)
                    {
                        _gameSecond = 0;
                        _gameMinute += 1;
                    }
                    if (_gameMinute == 60)
                    {
                        _gameMinute = 0;
                        _gameHour += 1;
                    }
                    lblGameTime.Text = string.Format("{0}:{1}:{2}", _gameHour.ToString().PadLeft(2, '0'), _gameMinute.ToString().PadLeft(2, '0'), _gameSecond.ToString().PadLeft(2, '0'));
                }));
            }catch(Exception e1)
            {
                gameTimer.Dispose();
                MessageBox.Show(e1.Message, "Error Message");
            }
        }
        public void MaterialDesignForm()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue50, Accent.LightBlue200, TextShade.WHITE);
        }

        public void DisposeTimerThreads()
        {
            // 실행한 Timer들을 모두 해제한다. 
            gameInitPreviewTimer.Dispose();
            gameCardStatusTimer.Dispose();
            gameCardIncorrectTimer.Dispose();
            gameCardCorrectTimer.Dispose();
        }

        public void ReStartGame()
        {
            // 게임이 다시시작될때 초기화를 해준다.
            lblScore.Text = "0";
            lblGameTime.Text = "00:00:00";
            _gameHour = 0; _gameMinute = 0; _gameSecond = 0;
            this.Text = "같은 영화 포스터 찾기 게임 | 사용자이름 : ";
        }
    }
}