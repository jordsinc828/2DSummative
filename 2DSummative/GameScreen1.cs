using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _2DSummative
{

    public partial class GameScreen1 : UserControl
    {
        #region Global Variables
        SolidBrush heroBrush = new SolidBrush(Color.White);
        SolidBrush wallBrush = new SolidBrush(Color.Black);
        SolidBrush fallBrush = new SolidBrush(Color.Green);
        SolidBrush shiftBrush = new SolidBrush(Color.Red);
        SolidBrush zigBrush = new SolidBrush(Color.Purple);
        SolidBrush winBrush = new SolidBrush(Color.LightGreen);

        List<Hero> hero = new List<Hero>();
        List<Boxes> boxes = new List<Boxes>();
        List<FallBox> fallboxes = new List<FallBox>();
        List<Platforms> platforms = new List<Platforms>();
        List<ZigZag> zig = new List<ZigZag>();
        List<winBox> win = new List<winBox>();
        Boolean aKeyDown, dKeyDown, wKeyDown, sKeyDown;
        int heroSpeed = 1;
        Color c = Color.Red;
        Hero hero1;
        Random randNum = new Random();
        #endregion
        public GameScreen1()
        {
            InitializeComponent();
            SetParameters();
        }

        private void GameScreen1_Load(object sender, EventArgs e)
        {

        }

        private void SetParameters()
        {
            gameTimer.Enabled = true;
            this.Refresh();
            yesButton.Visible = false;
            noButton.Visible = false;
            replayLabel.Visible = false;
            winLabel.Visible = false;

            hero1 = new Hero(15, 40, 10);
            hero.Add(hero1);

            #region  Platforms
            Platforms platform1 = new Platforms(175, 55, 40, 10, 3);
            platforms.Add(platform1);
            Platforms platform2 = new Platforms(175, 95, 40, 10, -3);
            platforms.Add(platform2);
            Platforms platform3 = new Platforms(150, 135, 40, 10, 3);
            platforms.Add(platform3);
            Platforms platform4 = new Platforms(150, 175, 40, 10, -3);
            platforms.Add(platform4);
            #endregion

            #region FallBoxes 
            FallBox fall1 = new FallBox(45, -15, 15, 15, 1);
            fallboxes.Add(fall1);
            FallBox fall2 = new FallBox(60, -15, 15, 15, 2);
            fallboxes.Add(fall2);
            FallBox fall3 = new FallBox(75, -15, 15, 15, 3);
            fallboxes.Add(fall3);
            FallBox fall4 = new FallBox(90, -15, 15, 15, 4);
            fallboxes.Add(fall4);
            #endregion

            #region WallBoxes
            Boxes boxRW = new Boxes(400, 0, 15, 240, 0);
            boxes.Add(boxRW);
            Boxes boxBW = new Boxes(0, 235, 400, 15, 0);
            boxes.Add(boxBW);
            Boxes boxLW = new Boxes(-15, 0, 15, 240, 0);
            boxes.Add(boxLW);
            Boxes boxTW = new Boxes(0, -15, 385, 15, 0);
            boxes.Add(boxTW);
            Boxes box1 = new Boxes(40, 0, 10, 175, 2);
            boxes.Add(box1);
            Boxes box2 = new Boxes(40, 175, 50, 10, 0);
            boxes.Add(box2);
            Boxes box3 = new Boxes(90, 175, 10, 10, 1);
            boxes.Add(box3);
            Boxes box4 = new Boxes(150, 50, 10, this.Height, 0);
            boxes.Add(box4);
            Boxes box5 = new Boxes(275, 0, 10, 200, 1);
            boxes.Add(box5);
            #endregion

            #region Zig Boxes
            ZigZag zig1 = new ZigZag(280, 50, 10, 10, 2, 2);
            zig.Add(zig1);
            ZigZag zig2 = new ZigZag(320, 70, 20, 20, -1, 1);
            zig.Add(zig2);
            ZigZag zig3 = new ZigZag(380, 100, 5, 5, -3, 3);
            zig.Add(zig3);
            ZigZag zig4 = new ZigZag(350, 0, 7, 7, 3, -3);
            zig.Add(zig4);
            ZigZag zig5 = new ZigZag(350, 0, 7, 7, -3, 3);
            zig.Add(zig5);
            ZigZag zig6 = new ZigZag(365, 0, 10, 10, 3, 3);
            zig.Add(zig6);

            #endregion

            #region WinBox
            winBox winBox = new winBox(280, 0, 140, 45);
            win.Add(winBox);
            #endregion

        }
        #region WinGame
        private void WinGame()
        {
            gameTimer.Enabled = false;
            replayLabel.Visible = true;
            noButton.Visible = true;
            yesButton.Visible = true;
            winLabel.Visible = true;
        }
        #endregion
        #region GameOver
        private void GameOver()
        {
            gameTimer.Enabled = false;
            replayLabel.Visible = true;
            noButton.Visible = true;
            yesButton.Visible = true;
        }
        #endregion

        #region KeyInputs
        private void GameScreen1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aKeyDown = false;
                    break;
                case Keys.D:
                    dKeyDown = false;
                    break;
                case Keys.W:
                    wKeyDown = false;
                    break;
                case Keys.S:
                    sKeyDown = false;
                    break;
            }
        }
        #region Buttons
        private void yesButton_Click(object sender, EventArgs e)
        {
            SetParameters();
            this.Refresh();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        private void GameScreen1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aKeyDown = true;
                    break;
                case Keys.D:
                    dKeyDown = true;
                    break;
                case Keys.W:
                    wKeyDown = true;
                    break;
                case Keys.S:
                    sKeyDown = true;
                    break;


            }
        }
        #endregion
        private void gameTimer_Tick(object sender, EventArgs e)
        {

            #region boxMoving

            #region Setup

            foreach (Boxes b in boxes)
            {
                b.Move();
            }

            foreach (FallBox f in fallboxes)
            {
                f.Fall();
            }

            foreach (Platforms p in platforms)
            {
                p.Shift();
            }
            foreach (ZigZag z in zig)
            {
                z.Zig();
            }


            #endregion
            #region Moving1

            if (boxes[4].sizeH == this.Height)
            {
                boxes[4].speed = -2;
            }
            else if (boxes[4].sizeH == 175)
            {
                boxes[4].speed = 2;
            }
            #endregion
            #region Moving2
            if (boxes[6].sizeH == 60)
            {
                boxes[6].speed = -5;
            }
            else if (boxes[6].sizeH == 10)
            {
                boxes[6].speed = 1;
            }
            #endregion
            #region Moving 3
            if (boxes[8].sizeH > 240)
            {
                boxes[8].speed = -3;
            }
            else if (boxes[8].sizeH < 190)
            {
                boxes[8].speed = 1;
            }
            #endregion 
            #region Falling1
            for (int i = 0; i < fallboxes.Count(); i++)
            {
                if (fallboxes[i].y > 165)
                {
                    fallboxes[i].y = -5;
                    int rand = randNum.Next(45, 145);
                    fallboxes[i].x = rand;
                }
                if (i == 4)
                {
                    i = 0;
                }
            }
            #endregion
            #region Shifting
            for (int i = 0; i < platforms.Count(); i++)
            {
                if (platforms[i].x > 240)
                {
                    platforms[i].speed = -3;
                }
                else if (platforms[i].x < 155)
                {
                    platforms[i].speed = +3;
                }
                #endregion
            #region ZigMoving1
                if (zig[0].y > 170)
                {
                    zig[0].speedY = -2;
                }
            else if (zig[0].y < 50)
                {
                    zig[0].speedY = 2;
                }
            if (zig[0].x > 390)
                {
                    zig[0].speedX = -2;
                }
            else if (zig[0].x < 280)
                {
                    zig[0].speedX = 2;
                }
                #endregion
            #region ZigMoving2
                if (zig[1].y > 170)
                {
                    zig[1].speedY = -1;
                }
                else if (zig[1].y < 50)
                {
                    zig[1].speedY = 1;
                }
                if (zig[1].x > 390)
                {
                    zig[1].speedX = -1;
                }
                else if (zig[1].x < 280)
                {
                    zig[1].speedX = 1;
                }
                #endregion
            #region ZigMoving3
                if (zig[2].y > 170)
                {
                    zig[2].speedY = -3;
                }
                else if (zig[2].y < 50)
                {
                    zig[2].speedY = 3;
                }
                if (zig[2].x > 390)
                {
                    zig[2].speedX = -3;
                }
                else if (zig[2].x < 280)
                {
                    zig[2].speedX = 3;
                }
                #endregion
            #region ZigMoving4
                if (zig[3].y > 170)
                {
                    zig[3].speedY = -3;
                }
                else if (zig[3].y < 50)
                {
                    zig[3].speedY = 3;
                }
                if (zig[3].x > 390)
                {
                    zig[3].speedX = -3;
                }
                else if (zig[3].x < 280)
                {
                    zig[3].speedX = 3;
                }
                #endregion
            #region ZigMoving5
                if (zig[4].y > 170)
                {
                    zig[4].speedY = -3;
                }
                else if (zig[4].y < 50)
                {
                    zig[4].speedY = 3;
                }
                if (zig[4].x > 390)
                {
                    zig[4].speedX = -3;
                }
                else if (zig[4].x < 280)
                {
                    zig[4].speedX = 3;
                }
                #endregion
            #region ZigMoving6
                if (zig[5].y > 170)
                {
                    zig[5].speedY = -3;
                }
                else if (zig[5].y < 50)
                {
                    zig[5].speedY = 3;
                }
                if (zig[5].x > 390)
                {
                    zig[5].speedX = -3;
                }
                else if (zig[5].x < 280)
                {
                    zig[5].speedX = 3;
                }
                #endregion
                #endregion

            #region heroMovement

                if (wKeyDown == true)
                {
                    hero1.y = hero1.y - heroSpeed;
                }

                if (aKeyDown == true)
                {
                    hero1.x = hero1.x - heroSpeed;
                }

                if (sKeyDown == true)
                {
                    hero1.y = hero1.y + heroSpeed;
                }

                if (dKeyDown == true)
                {
                    hero1.x = hero1.x + heroSpeed;
                }

                #endregion

            #region collisions

                Rectangle heroRec = new Rectangle(hero1.x, hero1.y, hero1.size, hero1.size);
                foreach (FallBox f in fallboxes)
                {
                    Rectangle fallRec = new Rectangle(f.x, f.y, f.sizeW, f.sizeH);
                    if (heroRec.IntersectsWith(fallRec))
                    {
                        GameOver();
                    }
                }
                foreach (Boxes b in boxes)
                {
                    Rectangle boxRec = new Rectangle(b.x, b.y, b.sizeW, b.sizeH);
                    if (heroRec.IntersectsWith(boxRec))
                    {
                        GameOver();
                    }
                }
                foreach (Platforms p in platforms)
                {
                    Rectangle platformRec = new Rectangle(p.x, p.y, p.sizeW, p.sizeH);
                    if (heroRec.IntersectsWith(platformRec))
                    {
                        GameOver();
                    }
                }
                foreach (ZigZag z in zig)
                {
                    Rectangle zigRec = new Rectangle(z.x, z.y, z.sizeW, z.sizeH);
                    if (heroRec.IntersectsWith(zigRec))
                    {
                        GameOver();
                    }
                foreach (winBox w in win)
                    {
                        Rectangle winRec = new Rectangle(w.x, w.y, w.sizeW, w.sizeH);
                        if (heroRec.IntersectsWith(winRec))
                        {

                            WinGame();
                        }
                    }
                }

                #endregion
                
            this.Refresh();
    }
        }

        #region Paint Method
        private void GameScreen1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(heroBrush, hero1.x, hero1.y, hero1.size, hero1.size);
            if (hero1.x > 40)
            {
                foreach (FallBox f in fallboxes)
                {
                    e.Graphics.FillEllipse(fallBrush, f.x, f.y, f.sizeW, f.sizeH);
                }
            }

            if (hero1.x > 150)
            {
                foreach (Platforms p in platforms)
                {
                    e.Graphics.FillRectangle(shiftBrush, p.x, p.y, p.sizeW, p.sizeH);
                }
            }

            if (hero1.x > 275)
            {
                foreach (ZigZag z in zig)
                {
                    e.Graphics.FillEllipse(zigBrush, z.x, z.y, z.sizeW, z.sizeH);
                }
                foreach (winBox w in win)
                {
                    e.Graphics.FillRectangle(winBrush, w.x, w.y, w.sizeW, w.sizeH);
                }
            }
          
            foreach (Boxes b in boxes)
                {
                    e.Graphics.FillRectangle(wallBrush, b.x, b.y, b.sizeW, b.sizeH);
                }


        }
        #endregion
    }

}
