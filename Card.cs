namespace Deck {
  public class Card {
    private char Suit {get; set;}
    private int Rank {get; set;}
    public Card(char c, int i) {
      Suit = c;
      Rank = i;
    }
    public override string ToString() {
      if (Rank == 1) return $"A{Suit}";
      if (Rank == 11) return $"J{Suit}";
      if (Rank == 12) return $"Q{Suit}";
      if (Rank == 13) return $"K{Suit}";
      else return $"{Rank}{Suit}";
    }
    public bool Equals(Card aCard) {
      if(!Suit.Equals(aCard.Suit) || !Rank.Equals(aCard.Rank))
        return false;
      return true;
    }
  }
}