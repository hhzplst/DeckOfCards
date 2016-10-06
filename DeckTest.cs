using System;

namespace Deck {
    public class DeckcTest {
        public static void Main(String[] args) {
            int counter = 0;
            Console.WriteLine("Creating two decks...");
            Deck myDeck = new Deck();
            Deck testDeck = new Deck();
            Console.WriteLine("the first deck looks like this...");
            myDeck.PrintDeck();
            Console.WriteLine("the second deck looks like this...");
            testDeck.PrintDeck();

            Console.WriteLine("Shuffling the second deck once...");
            testDeck.Shuffle();
            Console.WriteLine("Showing the second deck after the first shuffle...");
            testDeck.PrintDeck(); 

            while (!myDeck.Equals(testDeck) || counter < 20) {
                testDeck.Shuffle();
                counter++;
                Console.WriteLine("After the {0} shuffle, the deck becomes:", counter);
                testDeck.PrintDeck();
            }
            Console.WriteLine("It takes {0} times to return to its original order.\n", counter+1);
        }
    }
}

/***********************************OUTPUT**************************************

➜  Deck git:(master) ✗ dotnet run
Project Deck (.NETCoreApp,Version=v1.0) will be compiled because inputs were modified
Compiling Deck for .NETCoreApp,Version=v1.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.7775741
 

Creating two decks...
the first deck looks like this...
AH 2H 3H 4H 5H 6H 7H 8H 9H 10H JH QH KH 
AC 2C 3C 4C 5C 6C 7C 8C 9C 10C JC QC KC 
AD 2D 3D 4D 5D 6D 7D 8D 9D 10D JD QD KD 
AS 2S 3S 4S 5S 6S 7S 8S 9S 10S JS QS KS 


the second deck looks like this...
AH 2H 3H 4H 5H 6H 7H 8H 9H 10H JH QH KH 
AC 2C 3C 4C 5C 6C 7C 8C 9C 10C JC QC KC 
AD 2D 3D 4D 5D 6D 7D 8D 9D 10D JD QD KD 
AS 2S 3S 4S 5S 6S 7S 8S 9S 10S JS QS KS 


Shuffling the second deck once...
Showing the deck after the first shuffle...
AH AD 2H 2D 3H 3D 4H 4D 5H 5D 6H 6D 7H 
7D 8H 8D 9H 9D 10H 10D JH JD QH QD KH KD 
AC AS 2C 2S 3C 3S 4C 4S 5C 5S 6C 6S 7C 
7S 8C 8S 9C 9S 10C 10S JC JS QC QS KC KS 


After the 1 shuffle, the deck becomes:
AH AC AD AS 2H 2C 2D 2S 3H 3C 3D 3S 4H 
4C 4D 4S 5H 5C 5D 5S 6H 6C 6D 6S 7H 7C 
7D 7S 8H 8C 8D 8S 9H 9C 9D 9S 10H 10C 10D 
10S JH JC JD JS QH QC QD QS KH KC KD KS 


After the 2 shuffle, the deck becomes:
AH 7D AC 7S AD 8H AS 8C 2H 8D 2C 8S 2D 
9H 2S 9C 3H 9D 3C 9S 3D 10H 3S 10C 4H 10D 
4C 10S 4D JH 4S JC 5H JD 5C JS 5D QH 5S 
QC 6H QD 6C QS 6D KH 6S KC 7H KD 7C KS 


After the 3 shuffle, the deck becomes:
AH 4C 7D 10S AC 4D 7S JH AD 4S 8H JC AS 
5H 8C JD 2H 5C 8D JS 2C 5D 8S QH 2D 5S 
9H QC 2S 6H 9C QD 3H 6C 9D QS 3C 6D 9S 
KH 3D 6S 10H KC 3S 7H 10C KD 4H 7C 10D KS 


After the 4 shuffle, the deck becomes:
AH 9H 4C QC 7D 2S 10S 6H AC 9C 4D QD 7S 
3H JH 6C AD 9D 4S QS 8H 3C JC 6D AS 9S 
5H KH 8C 3D JD 6S 2H 10H 5C KC 8D 3S JS 
7H 2C 10C 5D KD 8S 4H QH 7C 2D 10D 5S KS 


After the 5 shuffle, the deck becomes:
AH 5H 9H KH 4C 8C QC 3D 7D JD 2S 6S 10S 
2H 6H 10H AC 5C 9C KC 4D 8D QD 3S 7S JS 
3H 7H JH 2C 6C 10C AD 5D 9D KD 4S 8S QS 
4H 8H QH 3C 7C JC 2D 6D 10D AS 5S 9S KS 


After the 6 shuffle, the deck becomes:
AH 3H 5H 7H 9H JH KH 2C 4C 6C 8C 10C QC 
AD 3D 5D 7D 9D JD KD 2S 4S 6S 8S 10S QS 
2H 4H 6H 8H 10H QH AC 3C 5C 7C 9C JC KC 
2D 4D 6D 8D 10D QD AS 3S 5S 7S 9S JS KS 


After the 7 shuffle, the deck becomes:
AH 2H 3H 4H 5H 6H 7H 8H 9H 10H JH QH KH 
AC 2C 3C 4C 5C 6C 7C 8C 9C 10C JC QC KC 
AD 2D 3D 4D 5D 6D 7D 8D 9D 10D JD QD KD 
AS 2S 3S 4S 5S 6S 7S 8S 9S 10S JS QS KS 


It takes 8 times to return to its original order.


***********************************END OUTPUT**********************************/