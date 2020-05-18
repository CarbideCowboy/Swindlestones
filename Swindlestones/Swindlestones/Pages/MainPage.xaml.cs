using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Swindlestones
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public int numberOfDice = 0;
        public Random random = new Random();
        public MainPage()
        {
            InitializeComponent();
        }

        public void UxRollButton_CLicked(object sender, EventArgs e)
        {
            RollDice();
        }

        public void RollDice()
        {
            switch(numberOfDice)
            {
                case 1:
                    RollDie(dice1Spot);
                    break;
                case 2:
                    RollDie(dice1Spot);
                    RollDie(dice2Spot);
                    break;
                case 3:
                    RollDie(dice1Spot);
                    RollDie(dice2Spot);
                    RollDie(dice3Spot);
                    break;
                case 4:
                    RollDie(dice1Spot);
                    RollDie(dice2Spot);
                    RollDie(dice3Spot);
                    RollDie(dice4Spot);
                    break;
                case 5:
                    RollDie(dice1Spot);
                    RollDie(dice2Spot);
                    RollDie(dice3Spot);
                    RollDie(dice4Spot);
                    RollDie(dice5Spot);
                    break;
            }
        }

        public void RollDie(Image image)
        {
            int roll = random.Next(1, 5);
            switch(roll)
            {
                case 1:
                    image.Source = "stone1.png";
                    break;
                case 2:
                    image.Source = "stone2.png";
                    break;
                case 3:
                    image.Source = "stone3.png";
                    break;
                case 4:
                    image.Source = "stone4.png";
                    break;
            }
        }

        public void UxAddButton_Clicked(object sender, EventArgs e)
        {
            if(numberOfDice < 5)
            {
                numberOfDice++;
                switch(numberOfDice)
                {
                    case 1:
                        dice1Spot.IsVisible = true;
                        dice2Spot.IsVisible = false;
                        dice3Spot.IsVisible = false;
                        dice4Spot.IsVisible = false;
                        dice5Spot.IsVisible = false;
                        RollDie(dice1Spot);
                        break;
                    case 2:
                        dice1Spot.IsVisible = true;
                        dice2Spot.IsVisible = true;
                        dice3Spot.IsVisible = false;
                        dice4Spot.IsVisible = false;
                        dice5Spot.IsVisible = false;
                        RollDie(dice2Spot);
                        break;
                    case 3:
                        dice1Spot.IsVisible = true;
                        dice2Spot.IsVisible = true;
                        dice3Spot.IsVisible = true;
                        dice4Spot.IsVisible = false;
                        dice5Spot.IsVisible = false;
                        RollDie(dice3Spot);
                        break;
                    case 4:
                        dice1Spot.IsVisible = true;
                        dice2Spot.IsVisible = true;
                        dice3Spot.IsVisible = true;
                        dice4Spot.IsVisible = true;
                        dice5Spot.IsVisible = false;
                        RollDie(dice4Spot);
                        break;
                    case 5:
                        dice1Spot.IsVisible = true;
                        dice2Spot.IsVisible = true;
                        dice3Spot.IsVisible = true;
                        dice4Spot.IsVisible = true;
                        dice5Spot.IsVisible = true;
                        RollDie(dice5Spot);
                        break;
                }
            }
        }

        public void UxSubtractButton_Clicked(object sender, EventArgs e)
        {
            if(numberOfDice > 0)
            {
                switch(numberOfDice)
                {
                    case 1:
                        dice1Spot.IsVisible = false;
                        break;
                    case 2:
                        dice2Spot.IsVisible = false;
                        break;
                    case 3:
                        dice3Spot.IsVisible = false;
                        break;
                    case 4:
                        dice4Spot.IsVisible = false;
                        break;
                    case 5:
                        dice5Spot.IsVisible = false;
                        break;
                }
                numberOfDice--;
            }
        }
    }
}
