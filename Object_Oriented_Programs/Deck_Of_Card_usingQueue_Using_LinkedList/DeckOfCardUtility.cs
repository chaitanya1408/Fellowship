using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya.Object_Oriented_Programs.Deck_Of_Card_usingQueue_Using_LinkedList
{
    class DeckOfCardUtility
    {
        /// <summary>
        /// Shuffles the specified deck.
        /// function:Shuffle(String[] deck)
        /// description: this function will get the parameter of an array from DeckofCardFunction.
        /// it will shuffle the element (interchange the position randomly)  till the deck length.
        /// and return the shuffled deck array
        /// </summary>
        /// <param name="deck">The deck.</param>
        /// <returns></returns>
        public static String[] Shuffle(String[] deck)
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
        /// <summary>
        /// Distributes the pages.
        /// </summary>
        /// this function will get parameter from the user like number of players, number of card to be distributed and the deck array.
        /// it will show in 2d array distributedPages
        /// <param name="players">The players.</param>
        /// <param name="pages">The pages.</param>
        /// <param name="deck">The deck.</param>
        public static void DistributePages(int players, int pages, String[] deck)
        {
            int numberOfPages = players * pages, k = 0;
            String[,] distributedPages = new String[players, pages];
            //if the cards to be distributed is maximum than number of cards in deck then this if condition will display enter valid input
            // and calls the DeckOfCardsFunction() again to get valid input 
            if (numberOfPages > deck.Length || numberOfPages <= 0)
            {
                Console.WriteLine("Enter valid Input");
                DeckOfCard.DeckOfCardsFunction();
            }
            // this else part display player with his cards and it will be in 2D array
            else
            {
                for (int i = 0; i < players; i++)
                {
                    //Console.WriteLine("Player:" + (i + 1));
                    for (int j = 0; j < pages; j++)
                    {
                        distributedPages[i, j] = deck[k];
                        k++;
                    }
                    //Console.WriteLine("");
                }
            }
            String[] array1 = new String[pages];
            String[] array2 = new String[pages];
            String[] array3 = new String[pages];
            String[] array4 = new String[pages];
            for (int i=0;i<players;)
            {
                for(int j=0;j<pages;j++)
                {
                    array1[j] = distributedPages[i, j];
                }
                i++;
                for (int j = 0; j < pages; j++)
                {
                    array2[j] = distributedPages[i, j];
                }
                i++;
                for (int j = 0; j < pages; j++)
                {
                    array3[j] = distributedPages[i, j];
                }
                i++;
                for (int j = 0; j < pages; j++)
                {
                    array4[j] = distributedPages[i, j];
                }
                
            }
            Array.Sort(array1);
            Array.Sort(array2);
            Array.Sort(array3);
            Array.Sort(array4);
            for(int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]+" ");
            }

        }
    }
}
