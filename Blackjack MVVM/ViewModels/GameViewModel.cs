using Blackjack_MVVM.Commands;
using Blackjack_MVVM.Converters;
using Blackjack_MVVM.Data;
using Blackjack_MVVM.Stores;
using Blackjack_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Blackjack_MVVM.ViewModels
{
    public class GameViewModel : BaseViewModel
    {
        public int PlayerScore { get; set; }
        public int CpuScore { get; set; }
        public int SessionScore { get; set; } // Variabel som ska hålla värdet får vunna/förlorade pengar under den aktuella sessionen
        public GenericCard Card { get; set; }
        public GameView gameView { get; set; }
        public PlayerScore playerScore { get; set; }

        public BettingButtons bettingButtons { get; set; }
        public PlaceBetButton placeBetButton { get; set; }
        public HitButton hitButton { get; set; }
        public StandButton standButton { get; set; }
        public CpuScore cpuScore { get; set; }
        private static readonly Random random = new Random();
        public ObservableCollection<GenericCard> DeckOfCards { get; set; }
        public ObservableCollection<GenericCard> PersonCardsInGame { get; set; } = new ObservableCollection<GenericCard>();
        public ObservableCollection<GenericCard> CpuCardsInGame { get; set; } = new ObservableCollection<GenericCard>();
        public Markers markers { get; set; }
        public SavedMarkers savedMarkers { get; set; }
        public CurrentBet currentbet { get; set; }
        public SessionTotal sessionTotal { get; set; }
        public PlayRules playRules { get; set; }
        public EnumToSymbolConverter converter = new EnumToSymbolConverter();
        public PlayMusic playMusic { get; set; }
        public StopMusic stopMusic { get; set; }
        public ICommand HitCommand { get; }
        public ICommand StandCommand { get; }
        public ICommand PlayAgainCommand { get; }
        public ICommand StopPlayingCommand { get; }
        public ICommand Bet1Command { get; }
        public ICommand Bet5Command { get; }
        public ICommand Bet10Command { get; }
        public ICommand Bet25Command { get; }
        public ICommand Bet100Command { get; }
        public ICommand ClearBetCommand { get; }
        public ICommand ReadRulesCommand { get; }
        public ICommand CloseRulesCommand { get; }
        public ICommand Choose1Command { get; }
        public ICommand Choose11Command { get; }
        public ICommand PlaceBetCommand { get; }
        public ICommand StartMusicCommand { get; }
        public ICommand StopMusicCommand { get; }

        public GenericCard newCard { get; set; }
        public Person p1 = new Person();
        public Cpu p2 = new Cpu();
        public string visibility { get; set; }
        public string winnervisibility { get; set; }

        public string betviewvisibility { get; set; }

        public string rulesvisibility { get; set; }
        public string playmusicvisibility { get; set; } 
        public string stopmusicvisibility { get; set; } 
        public string playmusicdisabling { get; set; } 
        public string stopmusicdisabling { get; set; } 
        public string acedecisionvisibility{ get; set; }

        public string cardvisibility { get; set; }

        public string buttonDisabling { get; set; }

        public string buttonDisabling2 { get; set; }
        public string hitToggle { get; set; }

        public string standToggle { get; set; }
        int totalbet = 0;
        int bet = 0;

        public string filename = "Blackjack_MVVM.json";

        public PlayViewModel playViewModel;

        public GameViewModel(NavigationStore navStore, MainWindow mainWindow)
        {
            gameView = new GameView();
            DeckOfCards = new ObservableCollection<GenericCard>();
            FillDeckOfCards();
            HitCommand = new HitCommand(this);
            PlayAgainCommand = new NavigationCommand<GameViewModel>(navStore, () => new GameViewModel(navStore, mainWindow));
            StopPlayingCommand = new StopPlayingCommand(this);
            StandCommand = new StandCommand(this);
            Bet1Command = new Bet1Command(this);
            Bet5Command = new Bet5Command(this);
            Bet10Command = new Bet10Command(this);
            Bet25Command = new Bet25Command(this);
            Bet100Command = new Bet100Command(this);
            ClearBetCommand = new ClearBetCommand(this);
            ReadRulesCommand = new ReadRulesCommand(this);
            CloseRulesCommand = new CloseRulesCommand(this);
            Choose1Command = new Choose1Command(this);
            Choose11Command = new Choose11Command(this);
            PlaceBetCommand = new PlaceBetCommand(this);
            StartMusicCommand = new StartMusicCommand(this, mainWindow);
            StopMusicCommand = new StopMusicCommand(this, mainWindow);
            currentbet = new CurrentBet();
            sessionTotal = new SessionTotal();
            savedMarkers = new SavedMarkers();
            playRules = new PlayRules();
            playMusic = new PlayMusic();
            stopMusic = new StopMusic();
            bettingButtons = new BettingButtons();
            placeBetButton = new PlaceBetButton();
            hitButton = new HitButton();
            hitToggle = "False";
            standToggle = "False";
            playmusicvisibility = "Hidden";
            stopmusicvisibility = "Visible";
            playmusicdisabling = "False";
            stopmusicdisabling = "True";

            betviewvisibility = "Visible";
            //sessionTotal.TotalSessionScore = 1;

            AddMarkers();
            if (File.Exists(filename))
                GetSavedMarkers(filename); 
        }

        public void DisableAndHidePlayMusic()
        {
            playmusicvisibility = "Hidden";
            
            playmusicdisabling = "False";
          
            playMusic.PlayMusicDisabling = playmusicdisabling;
            playMusic.PlayMusicVisible = playmusicvisibility;
            stopmusicvisibility = "Visible";
            stopmusicdisabling = "True";
            stopMusic.StopMusicDisabling = stopmusicdisabling;
            stopMusic.StopMusicVisible = stopmusicvisibility;
        }

        public void DisableAndHideStopMusic()
        {
            
            stopmusicvisibility = "Hidden";
            
            stopmusicdisabling = "False";
            stopMusic.StopMusicDisabling = stopmusicdisabling;
            stopMusic.StopMusicVisible = stopmusicvisibility;
            playmusicvisibility = "Visible";
            playmusicdisabling = "True";
            playMusic.PlayMusicDisabling = playmusicdisabling;
            playMusic.PlayMusicVisible = playmusicvisibility;
        }

        public void DisableBettingButtons()
        {
            buttonDisabling = "False";
            buttonDisabling2 = "True";
            bettingButtons.ButtonDisabling = buttonDisabling;
            placeBetButton.ButtonDisabling2 = buttonDisabling2;
            hitToggle = "True";
            standToggle = "True";            
        }

        #region CardFunctionality
        public void AddStartingCardsHuman()
        {
            AddCard();
            AddCard();
        }


        public void AddStartingCardsCpu()
        {
            AddCardCpu();

        }

        public char GetSuit()
        {
            int i = random.Next(1, 5);
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
            if (newCard.CardSuit == '♥' || newCard.CardSuit == '♦')
            {
                newCard.CardColor = "Red";
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
                Task.Delay(1000); // delay
            }
            if (newCard.CardSuit == '♥' || newCard.CardSuit == '♦')
            {
                newCard.CardColor = "Red";
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

        #region GameMechanics
        public void AddPlayerPoints(GenericCard card)
        {
            playerScore = new PlayerScore();
            int value;
           
            if (card.CardValue == "J" || card.CardValue == "Q" || card.CardValue == "K")
            {
                value = 10;
            }
            else if (card.CardValue == "A")
            {
                acedecisionvisibility = "Visible";
                value = 0;
            }
            else
            {
                value = int.Parse(card.CardValue);
            }
            p1.HandScore += value;

            playerScore.playerScore = p1.HandScore;
        }

        public int SetAceValue(int aceValue)
        {
            int chosenAceValue;
            chosenAceValue = aceValue;
            return chosenAceValue;
        }

        public void SetAceValueTo11()
        {
            p1.HandScore += 11;
            playerScore.playerScore = p1.HandScore;
        }

        public void SetAceValueTo1()
        {
            p1.HandScore += 1;
            playerScore.playerScore = p1.HandScore;
        }

        public int ReturnAceValue()
        {
            int ace = 0;
            int returnAce;
            returnAce = SetAceValue(ace);

            return returnAce;
        }

        public void AddCpuPoints(GenericCard card)
        {
            // gör om till en int så att vi kan räkna ut värdet.
            cpuScore = new CpuScore();
            int value;

            if (card.CardValue == "J" || card.CardValue == "Q" || card.CardValue == "K")
            {
                value = 10;
            }
            else if (card.CardValue == "A")
            {
                value = 11;
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

            if (p1.HandScore > 21 || HitAutoLoose() == true)
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

        public bool CpuWon()
        {
            if (p2.HandScore > p1.HandScore && p2.HandScore < 22 || p2.HandScore == p1.HandScore)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HitAutoLoose()
        {
            if (p1.HandScore > 21)
            {
               
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowMessage()
        {
            if (CpuWon() == true)
            {
                visibility = "Visible";
            }
            else
            {
                visibility = "Hidden";
                winnervisibility = "Visible";
            }
        }

        #endregion
        #region BettingFunctionality
        public void BettingTotal(int bet)
        {
            totalbet = totalbet += bet;
            p1.Bet = totalbet;
            currentbet.BetTotal = p1.Bet;

            buttonDisabling2 = "True";
            placeBetButton.ButtonDisabling2 = buttonDisabling2;
        }

        public void ClearBet()
        {
            currentbet.BetTotal = 0;
            totalbet = 0;
        }

        public void AddMarkers()
        {
            markers = new Markers();
            savedMarkers.MarkersSaved = 500;
            markers.MarkerTotal = savedMarkers.MarkersSaved;
        }

        public void CalculateMarkers()
        {
            if (CpuWon() == true || HitAutoLoose() == true)
            {
                savedMarkers.MarkersSaved = savedMarkers.MarkersSaved - totalbet;
                sessionTotal.TotalSessionScore = sessionTotal.TotalSessionScore - totalbet; // värde för sessionscore, funkar tills vyn resettas
            }
            else
            {
                savedMarkers.MarkersSaved = savedMarkers.MarkersSaved + (totalbet * 2);
                sessionTotal.TotalSessionScore = sessionTotal.TotalSessionScore + (totalbet * 2); // värde för sessionscore
            }
            markers.MarkerTotal = savedMarkers.MarkersSaved;
            savedMarkers.MarkersSaved = savedMarkers.MarkersSaved;
        }
        public void SaveMarkers()
        {
            FileHandler.Save(savedMarkers, filename);
        }

        public void GetSavedMarkers(string filename)
        {
            savedMarkers = FileHandler.Open<SavedMarkers>(filename);
            savedMarkers.MarkersSaved = savedMarkers.MarkersSaved;
            markers.MarkerTotal = savedMarkers.MarkersSaved;
        } 
        #endregion
    }
}
