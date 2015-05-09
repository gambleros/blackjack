using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class BlackJackForm : Form
    {
        public Deck deck;
        public bool Deal { get; set; }
        public bool Hit { get; set; }
        public bool Stand { get; set; }
        public int addWidth { get; set; }
        public int DrawCard { get; set; }
        public List<Card> Dealer;
        public List<Card> Player;
        public BlackJackForm()
        {
            InitializeComponent();
            deck = new Deck();
            Dealer=new List<Card>();
            Player=new List<Card>();
            addWidth = 10;
            lockBtn();
        }

        private void BlackJackForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(imageList1.Images[52], 10, 10);
            
            if (Deal)
            {
                Dealer.Add(deck.deck[DrawCard--]);
                g.DrawImageUnscaled(imageList1.Images[Dealer[0].Img], 160, 10);
                Player.Add(deck.deck[DrawCard--]);
                g.DrawImageUnscaled(imageList1.Images[Player[0].Img], 10, 300);
                Player.Add(deck.deck[DrawCard--]);
                g.DrawImageUnscaled(imageList1.Images[Player[1].Img], 160, 300);
                DealCards();
                Deal = false;
            }
            else if (Hit)
            {
                Player.Add(deck.deck[DrawCard--]);
                addWidth = 160;
                for (int i = 0; i < Dealer.Count; i++)
                {
                    g.DrawImageUnscaled(imageList1.Images[Dealer[i].Img], addWidth, 10);
                    addWidth += 150;
                }
                addWidth = 10;
                for (int i = 0; i < Player.Count; i++)
                {
                    g.DrawImageUnscaled(imageList1.Images[Player[i].Img], addWidth, 300);
                    addWidth += 150;
                }
                HitCards();
                Hit = false;
            }
            else if (Stand)
            {
                int sumD = sum(Dealer);
                while (sumD<=17)
                {
                    Card c = deck.deck[DrawCard--];
                    Dealer.Add(c);
                    sumD = sum(Dealer);
                }
                addWidth = 160;
                for (int i = 0; i < Dealer.Count; i++)
                {
                    g.DrawImageUnscaled(imageList1.Images[Dealer[i].Img], addWidth, 10);
                    addWidth += 150;
                }
                addWidth = 10;
                for (int i = 0; i < Player.Count; i++)
                {
                    g.DrawImageUnscaled(imageList1.Images[Player[i].Img], addWidth, 300);
                    addWidth += 150;
                }
                StandCards();
                Stand = false;
            }

        }
        private void StandCards()
        {
            msgSet(true);
            tbDealer.Text = sum(Dealer).ToString();
        }
        private void HitCards()
        {
            int playerScore = sum(Player);
            msgSet(false);
            tbPlayer.Text = playerScore.ToString();
        }
        private void msgSet(bool s)
        {
            int playerScore = sum(Player);
            int dealerScore = sum(Dealer);
            if (playerScore < 21 && dealerScore < 21)
            {
                if (s)
                {
                    if (playerScore > dealerScore)
                    {
                        WinText();
                    }
                    else if (playerScore < dealerScore) LoseText();
                    else DrawText();
                }
                else
                {
                    HitorStandText();
                }
     
            }
            else if (playerScore == 21 || dealerScore > 21)
            {
                WinText();
            }
            else if (playerScore > 21 || dealerScore == 21)
            {
                LoseText();
            }
        }
        private void DrawText()
        {
            tbAlert.Text = "Push";
            tbAlert.BackColor = Color.Orange;
            lockBtn();
        }
        private void HitorStandText()
        {
            tbAlert.Text = "Hit or Stand";
            tbAlert.BackColor = Color.Honeydew;
          
        }
        private void LoseText()
        {
            tbAlert.Text = "Lose";
            tbAlert.BackColor = Color.Red;
            lockBtn();
        }
        private void WinText()
        {
            tbAlert.Text = "Win";
            tbAlert.BackColor = Color.LightSeaGreen;
            lockBtn();
        }
        private void lockBtn(){
            btnHit.Enabled = false;
            btnStand.Enabled = false;
        }
        private void unlockBtn()
        {
            btnHit.Enabled = true;
            btnStand.Enabled = true;
        }
        private int sum(List<Card> cards)
        {
            int sum = 0;
            int aces = 0;
            for (int i = 0; i < cards.Count; i++)
            {
                sum += cards[i].Value;
                if (cards[i].Value == 11) aces++;
            }
            while (sum>21&&aces>0)
            {
                sum -= 10;
                aces--;
            }
            return sum;

        }
        private void DealCards()
        {
            msgSet(false);
            int sumP = sum(Player);
            tbPlayer.Text = sumP.ToString();
            int sumD = sum(Dealer);
            tbDealer.Text = sumD.ToString();
        }
        private void btnDeal_Click(object sender, EventArgs e)
        {
            Dealer.Clear();
            Player.Clear();
            deck.shuffle();
            DrawCard = 51;
            unlockBtn();
            Deal = true;
            Invalidate();
           
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            Hit = true;
            Invalidate();
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            Stand = true;
            Invalidate();
        }
    }
}
