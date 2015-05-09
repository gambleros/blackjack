#Blackjack 
**Семинарска задача по предметот Визуелно програмирање**
##Опис на играта Blackjack
Семинарската задача ја опфаќа добро познатата игра „Blackjack“.Blackjack е споредувачка игра 
на карти помеѓу играчот и дилерот.Поентата на играта е да се победи дилерот,што може да се 
направи на повеќе начини:
+ Добиј 21 поен во првите 2 карти(blackjack)
+ Добиј конечен резултат поголем од дилерот без да надминеш 21
+ Дозволи му на дилерот да влече карти додека не надмине 21 

Играчот првобитно добива 2 карти чиј збир е вредноста на раката.Крал,дама,џандар се сметаат 
како 10,Ас може да се смета како 11 или 1,додека сите останати карти ја иммат својата вредност.
Откако ќе ги добие 2те карти играчот има можност да направи `hit`,да земе уште една карта,или
да направи `stand`,дилерот извелкува карти се додека не направи вредност поголема од 17 или 
направи `bust`,збир поголем од 21 по што тој губи.

![alt text](https://github.com/gambleros/blackjack/blob/master/bjExample.png)

##Објаснување на имлементацијата на играта
Играта е изработена во C# Windows Forms.Целиот изглед е сместен во формата BlackJackForm
во која што се содржи поголемиот дел од логиката на играта.За чување на картите и шпилот карти
направени се класите Card и Deck соодветно.Во формата има 3 копчиња за интеракција и играње.Картите се слики кои се исцртуваат со Paint event кој ги зема картите од Player и Dealer листите и ги исцртува сите карти при секоја интеракција.Играта започнува со Deal завршува кога некој ќе добие или надмине 21.

###Card.cs
Врапер класа која служи за чување на картите и нивните вредности
###Deck.cs
Класа која ги доделува вредностите на картите,чува шпил карти и содржи функционалност за мешање на картите во шпилот.
##BlackJackForm
Главната класа во која е изгледот и логиката на играта во која има неколку поважни функции
```c#
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
```
Функцијата сум ја враќа сумата на картите притоа додава и посебен случај за Ас-овите со што овозможува сметање во согласност со правилата на играта т.е сметање на Ас како 11 или 1.
```c#
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
```
Деал методот е клик евент кој што ја ресетира играта,го меша шпилот од карти и ги овозможува другите функционалности на играта.
```c#
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
```
Paint методот е најглавната функција која ги поврзува изгледот со логиката.Во неа се додаваат нови карти во листите Player,Dealer,го исцртува целиот изглед на играта и ги повикува соодеветните методи за логиката во зависност од тоа кој дел од копчињата за интеракција е кликнат.

##Изработка
Александар Ѓорѓиевски 131112
