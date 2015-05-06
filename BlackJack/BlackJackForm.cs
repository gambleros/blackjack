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
        Random r;
        public List<Card> Dealer;
        public List<Card> Player;
        public BlackJackForm()
        {
            InitializeComponent();
            deck = new Deck();
            r = new Random();
            Dealer=new List<Card>();
            Player=new List<Card>();
            addWidth = 10;
        }

        private void BlackJackForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(imageList1.Images[52], 10, 10);
            
            if (Deal)
            {
                int pom = r.Next(52);
                Dealer.Add(deck.deck[pom]);
                g.DrawImageUnscaled(imageList1.Images[Dealer[0].Img], 160, 10);
                pom = r.Next(52);
                Player.Add(deck.deck[pom]);
                g.DrawImageUnscaled(imageList1.Images[Player[0].Img], 10, 300);
                pom = r.Next(52);
                Player.Add(deck.deck[pom]);
                g.DrawImageUnscaled(imageList1.Images[Player[1].Img], 160, 300);
                DealCards();
                Deal = false;
            }
            else if (Hit)
            {
                int pom = r.Next(52);
                Card c=deck.deck[pom];
                Player.Add(c);
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

        }
        private void HitCards()
        {
            int playerScore = sumPlayer();
            msgSet();
            tbPlayer.Text = playerScore.ToString();
        }
        private void msgSet()
        {
            int playerScore = sumPlayer();
            int dealerScore = sumDealer();
            if (playerScore < 21 && dealerScore < 21)
            {
                tbAlert.Text = "Hit or Stand";
                tbAlert.BackColor = Color.Honeydew;
            }
            else if (playerScore == 21 || dealerScore > 21)
            {
                tbAlert.Text = "Win";
                tbAlert.BackColor = Color.LightSeaGreen;
            }
            else if (playerScore > 21 || dealerScore == 21)
            {
                tbAlert.Text = "Lose";
                tbAlert.BackColor = Color.Red;
            }
        }
        private int sumPlayer()
        {
            int sum = 0;
            for (int i = 0; i < Player.Count; i++)
            {
                sum += Player[i].Value;
            }
            return sum;
        }
        private int sumDealer()
        {
            int sum = 0;
            for (int i = 0; i < Dealer.Count; i++)
            {
                sum += Dealer[i].Value;
            }
            return sum;
        }
        private void DealCards()
        {
            tbAlert.Text = "Hit or Stand";
            tbAlert.BackColor = Color.Honeydew;
            int sumP = sumPlayer();
            tbPlayer.Text = sumP.ToString();
            int sumD = sumDealer();
            tbDealer.Text = sumD.ToString();
        }
        private void btnDeal_Click(object sender, EventArgs e)
        {
            Dealer.Clear();
            Player.Clear();
            Deal = true;
            Invalidate();
           
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            Hit = true;
            Invalidate();
        }
    }
}
