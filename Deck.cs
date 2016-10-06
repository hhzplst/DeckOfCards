using System;

namespace Deck {
  public class Deck {
    const int NUM_SUITS_TYPE = 4;
    const int NUM_RANK_LEVEL = 13;
    private char[] suits = {'H', 'C', 'D', 'S'}; 
    private int[] ranks = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};   
    private Card[ , ] deckOfCards = new Card[NUM_SUITS_TYPE , NUM_RANK_LEVEL];
    public Card this[int i, int j] {
      get {
        return deckOfCards[i, j];
      }
    }
    public Deck() {
      for (int i = 0; i < NUM_SUITS_TYPE; i++)
        for (int j = 0; j < NUM_RANK_LEVEL; j++)
          deckOfCards[i,j] = new Card(suits[i], ranks[j]);
    }  
    public void PrintDeck() {
      for (int i = 0; i < NUM_SUITS_TYPE; i++) {
          for (int j = 0; j < NUM_RANK_LEVEL; j++)
            Console.Write(deckOfCards[i,j] + " ");               
          Console.WriteLine();
      }
      Console.WriteLine("\n");
    }
    public void Shuffle() {
      int temp = 0;
      Card[,] result = new Card[NUM_SUITS_TYPE, NUM_RANK_LEVEL];
      Card[,] temp1 = new Card[NUM_SUITS_TYPE / 2, NUM_RANK_LEVEL];
      Card[,] temp2 = new Card[NUM_SUITS_TYPE / 2, NUM_RANK_LEVEL];

      Array.Copy(deckOfCards, 0, temp1, 0, NUM_SUITS_TYPE * NUM_RANK_LEVEL / 2);
      Array.Copy(deckOfCards, NUM_SUITS_TYPE * NUM_RANK_LEVEL / 2, temp2, 0, NUM_SUITS_TYPE * NUM_RANK_LEVEL / 2);
     
      for (int i = 0; i < NUM_SUITS_TYPE * NUM_RANK_LEVEL / 2; i++) {
        Array.Copy(temp1, i, result, temp, 1);
        Array.Copy(temp2, i, result, ++temp , 1);
        temp++;
      }
      deckOfCards = result;
    }
    //assume the two decks are of the same size
    public bool Equals(Deck aDeck) {
      for (int i = 0; i < NUM_SUITS_TYPE; i++) {
          for (int j = 0; j < NUM_RANK_LEVEL; j++) {
            if (!(this[i, j]).Equals(aDeck[i, j]))
              return false;
          }               
      }
      return true;
    }
  }
}