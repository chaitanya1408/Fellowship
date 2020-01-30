// ******************************************************************************
//  <copyright file="Cards.cs" company="Bridgelabz">
//    Copyright © 2019 Company
//
//     Execution: Crds.cs
//  
//     Purpose: To call all the Function CardsInput
//     @author  Chaitanya Vaidya
//     @version 1.0
//     @since   30-01-2020
//  </copyright>
//  <creator name="Chaitanya Vaidya"/>
// ******************************************************************************
namespace FellowshipChaitanya.Object_Oriented_Programs.Deck_Of_Card_usingQueue_Using_LinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// cards is class
    /// </summary>
    class Cards
    {
        /// <summary>
        /// CardsInput is fubction which have suit rank arrays as a input.
        /// it call the multiple functions
        /// </summary>
        public static void CardsInput()
        {
            try
            {
                String[] suit = { "H", "S", "D", "C" };//array of suit
                String[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };//array of rank

                String[] deck = DeckOfCardUsingQueueUsingLinkedListUtility.Deck(rank, suit);//it will create a deck of cards

                Console.WriteLine("Enter the number of players:");// asking for how many players will play the game
                int players = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the number of cards each player can get:"); // asking for how many cards each player will get
                int cards = Convert.ToInt32(Console.ReadLine());

                DeckOfCardUsingQueueUsingLinkedListUtility.CheckInput(deck, players, cards);// input will be checked by this function

                String[] shuffleDeck = DeckOfCardUsingQueueUsingLinkedListUtility.ShufflingDeck(deck);//it will shuuffle the deck

                DeckOfCardUsingQueueUsingLinkedListUtility.DistributingCard(players, cards, shuffleDeck); //it will  the cards 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } 
    }
}
