﻿using Blackjack_MVVM.Commands;
using Blackjack_MVVM.Converters;
using Blackjack_MVVM.Data;
using Blackjack_MVVM.Stores;
using Blackjack_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Blackjack_MVVM.ViewModels
{
    public class GameViewModel : BaseViewModel
    {
        // presentera allt här i vyn
        // presentera ett enda kort

        public int PlayerScore { get; set; }
        public int CpuScore { get; set; }
        public GenericCard Card { get; set; }
        public GameView gameView { get; set; }

        public PlayerScore playerScore { get; set; }
        public CpuScore cpuScore { get; set; }
        private static readonly Random random = new Random();
        public ObservableCollection<GenericCard> DeckOfCards { get; set; }
        //public ObservableCollection<GenericCard> CardsInGame { get; set; }
        public ObservableCollection<GenericCard> PersonCardsInGame { get; set; } = new ObservableCollection<GenericCard>();
        public ObservableCollection<GenericCard> CpuCardsInGame { get; set; } = new ObservableCollection<GenericCard>();

        // cpucardsingame/playercardsingame
        public EnumToSymbolConverter converter = new EnumToSymbolConverter();
        public ICommand HitCommand { get; }
        public ICommand StandCommand { get; }
        public ICommand PlayAgainCommand { get;}
        public ICommand StopPlayingCommand { get;}
        public GenericCard newCard { get; set; }
        public Person p1 = new Person();
        public Cpu p2 = new Cpu();
        public string visibility { get; set; }
        public string winnervisibility { get; set; }

        public string cardvisibility { get; set; }


        public GameViewModel(NavigationStore navStore)
        {
            DeckOfCards = new ObservableCollection<GenericCard>();
            FillDeckOfCards();
            AddStartingCardsHuman();
            AddStartingCardsCpu();
            HitCommand = new HitCommand(this);
            PlayAgainCommand = new NavigationCommand<GameViewModel>(navStore, () => new GameViewModel(navStore));
            StopPlayingCommand = new StopPlayingCommand(this);
            StandCommand = new StandCommand(this);
        }

        #region CardFunctionality
        private void AddStartingCardsHuman()
        {
            AddCard();
            AddCard();
        }

        private void AddStartingCardsCpu()
        {
            AddCardCpu();

        }

        public char GetSuit()
        {
            int i = random.Next(1, 4);
            if (i == 1)
            {
                Card.CardSuit = '♥';
            }
            else if (i == 2)
            {
                Card.CardSuit = '♠';
            }
            else if (i == 3)
            {
                Card.CardSuit = '♣';
            }
            else
            {
                Card.CardSuit = '♦';
            }

            return Card.CardSuit;
        }

        public string GetValue()
        {
            int x = random.Next(1, 14);
            if (x == 1 || x == 14)
            {
                Card.CardValue = "A";
            }
            else if (x == 11)
            {
                Card.CardValue = "J";
            }
            else if (x == 12)
            {
                Card.CardValue = "Q";
            }
            else if (x == 13)
            {
                Card.CardValue = "K";
            }
            else
            {
                Card.CardValue = x.ToString();
            }
            return Card.CardValue;
        }

        //public string GetVisibility(GenericCard card)
        //{
        //    string cardVisibility = "Visible";
        //    while ()
        //    {
        //        Card.CardVisibility = cardVisibility;
        //    }
        //}

        public GenericCard GenerateCards()
        {
            Card = new GenericCard();
            DeckOfCards.Add(new GenericCard
            {
                CardValue = GetValue(),
                CardSuit = GetSuit(),
                CardVisibility = "Visible"
                                
            });

            return Card;
        }

        public void AddCard()
        {
            cardvisibility = "Visible";
            newCard = new GenericCard();
            int x = GetRandomCard();
            if (true)
            {
                newCard = DeckOfCards[x];
                newCard.CardVisibility = cardvisibility;
            }
            PersonCardsInGame.Add(newCard);
            PersonCardsInGame[0].CardVisibility = "Visible";
            AddPlayerPoints(newCard);
        }

        public void AddCardCpu()
        {
            newCard = new GenericCard();
            int x = GetRandomCard();
            if (true)
            {
                newCard = DeckOfCards[x];
            }
            CpuCardsInGame.Add(newCard);
            AddCpuPoints(newCard);
        }

        public void FillDeckOfCards()
        {
            int count = 0;

            while (count < 52)
            {
                GenerateCards();
                count++;
            }
        }

        public int GetRandomCard()
        {
            int idRandomCard;

            Random randomCard = new Random();
            idRandomCard = randomCard.Next(1, 52);

            return idRandomCard;
        } 
        #endregion


        public void AddPlayerPoints(GenericCard card)
        {
            // gör om till en int så att vi kan räkna ut värdet.
            playerScore = new PlayerScore();
            int value;

            if (card.CardValue == "A" || card.CardValue == "J" || card.CardValue == "Q" || card.CardValue == "K")
            {
                value = 10;
            }
            else
            {
                value = int.Parse(card.CardValue);
            }
            p1.HandScore += value;

            playerScore.playerScore = p1.HandScore;

        }

        public void AddCpuPoints(GenericCard card)
        {
            // gör om till en int så att vi kan räkna ut värdet.
            cpuScore = new CpuScore();
            int value;

            if (card.CardValue == "A" || card.CardValue == "J" || card.CardValue == "Q" || card.CardValue == "K")
            {
                value = 10;
            }
            else
            {
                value = int.Parse(card.CardValue);
            }
            p2.HandScore += value;
            cpuScore.cpuScore = p2.HandScore;
        }

        public bool PersonIsBust(Person p1)
        {
           
            if (p1.HandScore >21)
            {
                visibility = "Visible";
                return true;   
            }
            else
            {
                return false;
            }
        }

        public bool CpuIsBust(Cpu p2)
        {
            if (p2.HandScore > 21)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        //public void ShowNewCard()
        //{
        //    Card.CardVisibility = "Visible";
        //}

       public void CpuWon(Cpu p2, Person p1)
        {
            if (p2.HandScore > p1.HandScore && p2.HandScore < 22 || p2.HandScore == p1.HandScore)
            {
                visibility = "Visible";
                
    
            }
            else
            {
                visibility = "Hidden";
                winnervisibility = "Visible";
            }
        }

        //test1
    }
}
