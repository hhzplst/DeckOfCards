using System;

namespace Deck {
  public class Deck {
    private char[] suits = {'H', 'C', 'D', 'S'};
    private int[] ranks = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13}; 
    private Card[,] deckOfCards = new Card[4,13];
    public Deck() {
      for (int i = 0; i < suits.Length; i++)
        for (int j = 0; j < ranks.Length; j++)
          deckOfCards[i,j] = new Card(suits[i], ranks[j]);
    }  
    public void PrintDeck() {
      for (int i = 0; i < deckOfCards.GetLength(0); i++) {
          for (int j = 0; j < deckOfCards.GetLength(1); j++)
            Console.Write(deckOfCards[i,j] + " ");               
          Console.WriteLine();
      }
    }
    public void Shuffle() {
      
    }

  }
}