using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace game
{
    public partial class frmSolitaire : Form
    {
        class Card
        {
            public Image Image;
            public int Number;
            public int Suit;
            public bool IsRed;
            public bool FaceUp;
        }

        List<Card> deck = new List<Card>();
        List<Card> stock = new List<Card>();
        List<Card> waste = new List<Card>();
        Random rnd = new Random();

        int score = 0;
        int cardGap = 22;
        int cardW = 90;
        int cardH = 130;

        SoundPlayer winSound;
        SoundPlayer sameSuitSound;
        SoundPlayer needASound;
        SoundPlayer redBlackSound;
        SoundPlayer needKSound;

        public frmSolitaire()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCards();
            LoadSounds();
            SetEvents();
            AutoLayoutGame();
            NewGame();

            this.Resize += (s, e2) => AutoLayoutGame();
        }

        void LoadSounds()
        {
            
                winSound =
                    new SoundPlayer(
                        Properties.Resources.win);

                sameSuitSound =
                    new SoundPlayer(
                        Properties.Resources.sameSuit);

                needASound =
                    new SoundPlayer(
                        Properties.Resources.needA);

                redBlackSound =
                    new SoundPlayer(
                        Properties.Resources.redBlack);

                needKSound =
                    new SoundPlayer(
                        Properties.Resources.needK);
            }

        void LoadCards()
        {
            deck.Clear();

            for (int i = 1; i <= 52; i++)
            {
                object img = Properties.Resources.ResourceManager.GetObject("pic" + i);

                if (img != null)
                {
                    Card c = new Card();

                    c.Image = (Image)img;

                    // pic1=梅花A, pic2=方塊A, pic3=愛心A, pic4=黑桃A
                    c.Number = (i - 1) / 4 + 1;
                    c.Suit = (i - 1) % 4;
                    c.IsRed = c.Suit == 1 || c.Suit == 2;
                    c.FaceUp = false;

                    deck.Add(c);
                }
            }
        }

        void SetEvents()
        {
            this.MinimumSize = new Size(1000, 700);

            picDeck.SizeMode = PictureBoxSizeMode.StretchImage;
            picWaste.SizeMode = PictureBoxSizeMode.StretchImage;
            picWaste.MouseDown += Card_MouseDown;

            Panel[] cols =
            {
                pnlCol1, pnlCol2, pnlCol3, pnlCol4,
                pnlCol5, pnlCol6, pnlCol7
            };

            foreach (Panel p in cols)
            {
                p.AllowDrop = true;
                p.DragEnter += Panel_DragEnter;
                p.DragDrop += Panel_DragDrop;
            }

            PictureBox[] finish =
            {
                picFinish1, picFinish2, picFinish3, picFinish4
            };

            foreach (PictureBox p in finish)
            {
                p.AllowDrop = true;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.DragEnter += Finish_DragEnter;
                p.DragDrop += Finish_DragDrop;
            }
        }

        void AutoLayoutGame()
        {
            int topY = 80;
            int tableY = 220;

            picDeck.Size = new Size(cardW, cardH);
            picWaste.Size = new Size(cardW, cardH);

            picDeck.Location = new Point(25, topY);
            picWaste.Location = new Point(130, topY);

            lblScore.Location = new Point(260, 35);

            int finishStartX = this.ClientSize.Width - 480;

            if (finishStartX < 520)
                finishStartX = 520;

            PictureBox[] finish =
            {
                picFinish1, picFinish2, picFinish3, picFinish4
            };

            for (int i = 0; i < 4; i++)
            {
                finish[i].Size = new Size(cardW, cardH);
                finish[i].Location = new Point(finishStartX + i * 110, topY);
            }

            Panel[] cols =
            {
                pnlCol1, pnlCol2, pnlCol3, pnlCol4,
                pnlCol5, pnlCol6, pnlCol7
            };

            int left = 25;
            int right = 25;
            int panelW = 100;

            int gap = (this.ClientSize.Width - left - right - 7 * panelW) / 6;

            if (gap < 15)
                gap = 15;

            for (int i = 0; i < 7; i++)
            {
                cols[i].Location = new Point(left + i * (panelW + gap), tableY);
                cols[i].Size = new Size(panelW, this.ClientSize.Height - tableY - 30);
            }

            RepositionCards();
        }

        void NewGame()
        {
            score = 0;
            lblScore.Text = "Score: 0";

            stock.Clear();
            waste.Clear();

            picDeck.Image = Properties.Resources.back;
            picWaste.Image = null;
            picWaste.Tag = null;
            picWaste.BackColor = Color.DarkOliveGreen;

            picFinish1.Image = null;
            picFinish2.Image = null;
            picFinish3.Image = null;
            picFinish4.Image = null;

            picFinish1.Tag = null;
            picFinish2.Tag = null;
            picFinish3.Tag = null;
            picFinish4.Tag = null;

            pnlCol1.Controls.Clear();
            pnlCol2.Controls.Clear();
            pnlCol3.Controls.Clear();
            pnlCol4.Controls.Clear();
            pnlCol5.Controls.Clear();
            pnlCol6.Controls.Clear();
            pnlCol7.Controls.Clear();

            foreach (Card c in deck)
                c.FaceUp = false;

            ShuffleDeck();
            DealCards();
            RepositionCards();
        }

        void ShuffleDeck()
        {
            for (int i = 0; i < deck.Count; i++)
            {
                int j = rnd.Next(deck.Count);

                Card temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }

        void DealCards()
        {
            Panel[] cols =
            {
                pnlCol1, pnlCol2, pnlCol3, pnlCol4,
                pnlCol5, pnlCol6, pnlCol7
            };

            int index = 0;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Card card = deck[index];

                    if (j == i)
                        card.FaceUp = true;

                    PictureBox pb = CreateCardBox(card);
                    pb.Location = new Point(0, j * cardGap);

                    cols[i].Controls.Add(pb);
                    pb.BringToFront();

                    index++;
                }
            }

            for (int i = index; i < deck.Count; i++)
            {
                stock.Add(deck[i]);
            }
        }

        PictureBox CreateCardBox(Card card)
        {
            PictureBox pb = new PictureBox();

            pb.Tag = card;
            pb.Image = card.FaceUp ? card.Image : Properties.Resources.back;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(cardW, cardH);
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Cursor = Cursors.Hand;
            pb.MouseDown += Card_MouseDown;

            return pb;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (stock.Count == 0)
            {
                if (waste.Count == 0)
                    return;

                stock.AddRange(waste);
                waste.Clear();

                picWaste.Image = null;
                picWaste.Tag = null;
                picDeck.Image = Properties.Resources.back;

                return;
            }

            Card c = stock[0];
            stock.RemoveAt(0);

            c.FaceUp = true;
            waste.Add(c);

            UpdateWaste();
        }

        void UpdateWaste()
        {
            if (waste.Count == 0)
            {
                picWaste.Image = null;
                picWaste.Tag = null;
                return;
            }

            Card top = waste[waste.Count - 1];

            picWaste.Image = top.Image;
            picWaste.Tag = top;
        }

        private void picDeck_Click(object sender, EventArgs e)
        {
            btnDraw_Click(sender, e);
        }

        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            if (pb == null || pb.Tag == null)
                return;

            Card c = pb.Tag as Card;

            if (c == null || c.FaceUp == false)
                return;

            pb.DoDragDrop(pb, DragDropEffects.Move);
        }

        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBox)))
                e.Effect = DragDropEffects.Move;
        }

        private void Finish_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBox)))
                e.Effect = DragDropEffects.Move;
        }

        private void Panel_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox movingBox = e.Data.GetData(typeof(PictureBox)) as PictureBox;
            Panel target = sender as Panel;

            if (movingBox == null || target == null)
                return;

            List<PictureBox> movingCards = GetMovingCards(movingBox);

            if (!IsValidSequence(movingCards))
                return;

            Card moving = movingCards[0].Tag as Card;

            if (target.Controls.Count == 0)
            {
                if (moving.Number != 13)
                {
                    needKSound.Play();
                    MessageBox.Show("空白欄只能放K");
                    return;
                }
            }
            else
            {
                PictureBox bottomBox = GetBottomCard(target);
                Card bottom = bottomBox.Tag as Card;

                if (moving.IsRed == bottom.IsRed ||
                    moving.Number != bottom.Number - 1)
                {
                    redBlackSound.Play();
                    MessageBox.Show("必須紅黑交錯且遞減");
                    return;
                }
            }

            MoveCardsToPanel(movingCards, target);
        }

        void MoveCardsToPanel(List<PictureBox> movingCards, Panel target)
        {
            PictureBox first = movingCards[0];

            if (first == picWaste)
            {
                Card c = first.Tag as Card;

                PictureBox newBox = CreateCardBox(c);
                newBox.Location = new Point(0, target.Controls.Count * cardGap);

                target.Controls.Add(newBox);
                newBox.BringToFront();

                waste.Remove(c);
                UpdateWaste();

                AddScore(5);
                return;
            }

            Panel oldPanel = first.Parent as Panel;

            foreach (PictureBox p in movingCards)
                oldPanel.Controls.Remove(p);

            int y = target.Controls.Count * cardGap;

            foreach (PictureBox p in movingCards)
            {
                p.Location = new Point(0, y);
                target.Controls.Add(p);
                p.BringToFront();
                y += cardGap;
            }

            RevealTopCard(oldPanel);
            RepositionCards();
        }

        private void Finish_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox movingBox = e.Data.GetData(typeof(PictureBox)) as PictureBox;
            PictureBox finish = sender as PictureBox;

            if (movingBox == null || finish == null)
                return;

            Card moving = movingBox.Tag as Card;

            if (moving == null)
                return;

            Panel parentPanel = movingBox.Parent as Panel;

            if (parentPanel != null)
            {
                PictureBox bottom = GetBottomCard(parentPanel);

                if (bottom != movingBox)
                    return;
            }

            if (finish.Tag == null)
            {
                if (moving.Number != 1)
                {
                    needASound.Play();
                    MessageBox.Show("完成區第一張必須是A");
                    return;
                }
            }
            else
            {
                Card top = finish.Tag as Card;

                if (moving.Suit != top.Suit ||
                    moving.Number != top.Number + 1)
                {
                    sameSuitSound.Play();
                    MessageBox.Show("完成區必須同花色");
                    return;
                }
            }

            finish.Image = moving.Image;
            finish.Tag = moving;

            if (movingBox == picWaste)
            {
                waste.Remove(moving);
                UpdateWaste();
            }
            else
            {
                Panel oldPanel = movingBox.Parent as Panel;

                oldPanel.Controls.Remove(movingBox);
                movingBox.Dispose();

                RevealTopCard(oldPanel);
            }

            AddScore(10);
            RepositionCards();
            CheckWin();
        }

        List<PictureBox> GetMovingCards(PictureBox start)
        {
            List<PictureBox> list = new List<PictureBox>();

            if (start == picWaste)
            {
                list.Add(start);
                return list;
            }

            Panel panel = start.Parent as Panel;

            if (panel == null)
            {
                list.Add(start);
                return list;
            }

            foreach (Control ctrl in panel.Controls)
            {
                PictureBox p = ctrl as PictureBox;

                if (p != null && p.Location.Y >= start.Location.Y)
                    list.Add(p);
            }

            list.Sort((a, b) => a.Location.Y.CompareTo(b.Location.Y));

            return list;
        }

        bool IsValidSequence(List<PictureBox> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                Card upper = list[i].Tag as Card;
                Card lower = list[i + 1].Tag as Card;

                if (upper == null || lower == null)
                    return false;

                if (upper.IsRed == lower.IsRed)
                    return false;

                if (lower.Number != upper.Number - 1)
                    return false;
            }

            return true;
        }

        PictureBox GetBottomCard(Panel panel)
        {
            PictureBox bottom = null;

            foreach (Control ctrl in panel.Controls)
            {
                PictureBox p = ctrl as PictureBox;

                if (p != null)
                {
                    if (bottom == null || p.Location.Y > bottom.Location.Y)
                        bottom = p;
                }
            }

            return bottom;
        }

        void RevealTopCard(Panel panel)
        {
            if (panel == null)
                return;

            PictureBox bottom = GetBottomCard(panel);

            if (bottom == null)
                return;

            Card c = bottom.Tag as Card;

            if (c != null && c.FaceUp == false)
            {
                c.FaceUp = true;
                bottom.Image = c.Image;
                AddScore(5);
            }
        }

        void RepositionCards()
        {
            Panel[] cols =
            {
                pnlCol1, pnlCol2, pnlCol3, pnlCol4,
                pnlCol5, pnlCol6, pnlCol7
            };

            foreach (Panel panel in cols)
            {
                List<PictureBox> list = new List<PictureBox>();

                foreach (Control ctrl in panel.Controls)
                {
                    PictureBox p = ctrl as PictureBox;

                    if (p != null)
                        list.Add(p);
                }

                list.Sort((a, b) => a.Location.Y.CompareTo(b.Location.Y));

                for (int i = 0; i < list.Count; i++)
                {
                    list[i].Size = new Size(cardW, cardH);
                    list[i].Location = new Point(0, i * cardGap);
                    list[i].BringToFront();
                }
            }
        }

        void AddScore(int point)
        {
            score += point;
            lblScore.Text = "Score: " + score;
        }

        void CheckWin()
        {
            PictureBox[] finish =
            {
                picFinish1, picFinish2, picFinish3, picFinish4
            };

            foreach (PictureBox p in finish)
            {
                if (p.Tag == null)
                    return;

                Card c = p.Tag as Card;

                if (c.Number != 13)
                    return;
            }

            winSound.Play();
            MessageBox.Show("恭喜完成接龍！");
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}