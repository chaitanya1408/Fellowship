using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya.Object_Oriented_Programs.Deck_Of_Card_usingQueue_Using_LinkedList
{
    class DeckOfCard
    {
        public static void DeckOfCardsFunction()
        {
            String[] suit = { "heart", "club", "diamond", "spead" };//suit array
            String[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };//card rank array
            int n = suit.Length * rank.Length;//here we found rank of deck
            String[] deck = new String[n];

            try
            {
                ///we added elements in the deck throughthese for lopps
                for (int i = 0; i < rank.Length; i++)
                {
                    for (int j = 0; j < suit.Length; j++)
                    {
                        deck[suit.Length * i + j] = rank[i] + " of " + suit[j];
                    }
                }
                ///shuffled deck array will get the shuffled value from the function DeckOfCardUtility.shuffle().
                ///we just passed out deck array whrere all the cards are stored
                String[] shuffledDeck = DeckOfCardUtility.Shuffle(deck);
                Console.WriteLine("Enter number of players in whick do you want to distribute the pages: ");
                int players = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many cards do you want to distribute?");
                int pages = Convert.ToInt32(Console.ReadLine());
                ///this function is use to distribue the card to the number of players
                DeckOfCardUtility.DistributePages(players, pages, shuffledDeck);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
