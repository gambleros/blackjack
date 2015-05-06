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
        }
        private void DealCards()
        {
            tbAlert.Text = "Hit or Stand";
            int sum = 0;
            for (int i = 0; i < Player.Count; i++)
            {
                sum += Player[i].Value;
            }
            tbPlayer.Text = sum.ToString();
            sum = 0;
            for (int i = 0; i < Dealer.Count; i++)
            {
                sum += Dealer[i].Value;
            }
            tbDealer.Text = sum.ToString();
        }
        private void btnDeal_Click(object sender, EventArgs e)
        {
            Dealer.Clear();
            Player.Clear();
            Deal = true;
            Invalidate();
           
        }
    }
}
