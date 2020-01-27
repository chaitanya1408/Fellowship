using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya.Object_Oriented_Programs
{
    class DeckOfCards
    {
        public static void DeckOfCardsFunction()
        {
            Random rand = new Random();
            String[] suit ={ "heart","club","diamond","spead"};
            String[] rank ={ "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K","A" };
            int first = suit.Length;
            int second = rank.Length;
            int n = first * second;
            String[] deck = new String[first*second];
            for(int i = 0; i < second; i++)
            {
                for(int j = 0; j < first; j++)
                {
                    deck[first * i + j] = rank[i] + " of " + suit[j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                int r = i + (int)(rand.Next() * (n - i));
                String temp = deck[r];
                deck[r] = deck[i];
                deck[i] = temp;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(deck[i]+" ");
            }

        }
    }
}
