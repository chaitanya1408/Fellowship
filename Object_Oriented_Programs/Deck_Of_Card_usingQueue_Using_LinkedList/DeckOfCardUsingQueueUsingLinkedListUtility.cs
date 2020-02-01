using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya.Object_Oriented_Programs.Deck_Of_Card_usingQueue_Using_LinkedList
{
    class DeckOfCardUsingQueueUsingLinkedListUtility
    {
        /// <summary>
        /// Decks the specified rank.
        /// </summary>
        /// <param name="rank">The rank is array which stored the rank of card.</param>
        /// <param name="suit">The suit is array which store the suit of card.</param>
        /// Description:this function creates deck with compbining ranks and suit
        /// <returns></returns>
        public static String[] Deck(String[] rank, String[] suit)
        {
            try
            {

                String[] deck = new String[suit.Length * rank.Length];

                //creatind deck of cards using both the suit array and rank array
                for (int i = 0; i < rank.Length; i++)
                {
                    for (int j = 0; j < suit.Length; j++)
                    {
                        deck[suit.Length * i + j] = rank[i] + suit[j];// deck array stores rank and suit E.G. 5H,4S
                    }
                }
                return deck;//return a deck array of size 52
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Checks the input.
        /// </summary>
        /// <param name="deck">The deck is array which stored the cards.</param>
        /// <param name="players">The players is variable which stored the number of player.</param>
        /// <param name="cards">The cards is variable which stored the number of cards which we have to distribute to each palyer.
        /// if the cards to be distribute is more than a size of deck of deck or the ero or the less then it will write false else true
        /// <returns></returns>
        public static Boolean CheckInput(String[] deck, int players, int cards)
        {
            try
            {
                if (players * cards > deck.Length || players * cards <= 0)
                {
                    Console.WriteLine("Enter valid input!!");
                    Cards.CardsInput();
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Shufflings the deck.
        /// it will return the deck
        /// </summary>
        /// <param name="deck">The deck.</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static String[] ShufflingDeck(String[] deck)
        {
            try
            {
                Random rand = new Random();
                for (int i = 0; i < deck.Length; i++)
                {
                    int r = (int)(rand.NextDouble() * 51);//calls the random numbers betweemn 0 to 51 and assign to r
                    String temp = deck[r];
                    deck[r] = deck[i];
                    deck[i] = temp;
                }
                return deck;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        /// <summary>
        /// Distributings the card.
        /// this function will get parameter from the user like number of players, number of card to be distributed and the deck array.
        /// it will show in 2d array distributedPages
        /// </summary>
        /// <param name="players">The players.</param>
        /// <param name="cards">The cards.</param>
        /// <param name="shuffleDeck">The shuffle deck.</param>
        /// <exception cref="Exception"></exception>
        public static void DistributingCard(int players,int cards,String[] shuffleDeck)
        {
            try
            {
                QueueUsingLinkedList playersque = new QueueUsingLinkedList();
                QueueUsingLinkedList cardsque = new QueueUsingLinkedList();
                for (int i = 0; i < players * cards; i++)
                {
                    cardsque.Enqueue(shuffleDeck[i]);//cards are enqueue in cardsque
                }
                for (int i = 0; i < players; i++)
                {
                    playersque.Enqueue("Player:" + (i + 1));//players are enqueue in playersque
                }
                playersque.Show();
                while (!playersque.IsEmpty())
                {
                    Console.WriteLine(playersque.Get());

                    for (int j = 0; j < cards; j++)
                    {
                        Console.Write(cardsque.Get() + " ");
                        cardsque.Dequeue();
                    }

                    Console.WriteLine("");
                    playersque.Dequeue();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
