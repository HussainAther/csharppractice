class Card
{
    public string Face { get; set; }
    public Suit Suit { get; set; }
    
    public override string ToString()
    {  
    string card = "(" + this.Face + " " + this.Suit + ")";
    return card;
    }
}

enum Suit
{
    CLUB, DIAMOND, HEART, SPADE
}
