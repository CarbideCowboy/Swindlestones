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

        public async void UxRollButton_CLicked(object sender, EventArgs e)
        {
            await RollDice();
        }

        public async Task RollDice()
        {
            switch(numberOfDice)
            {
                case 1:
                    await RollDie(dice1Spot);
                    break;
                case 2:
                    _ = RollDie(dice1Spot);
                    await Task.Delay(300);
                    _ = RollDie(dice2Spot);
                    break;
                case 3:
                    _ = RollDie(dice1Spot);
                    await Task.Delay(300);
                    _ = RollDie(dice2Spot);
                    await Task.Delay(300);
                    _ = RollDie(dice3Spot);
                    break;
                case 4:
                    _ = RollDie(dice1Spot);
                    await Task.Delay(300);
                    _ = RollDie(dice2Spot);
                    await Task.Delay(300);
                    _ = RollDie(dice3Spot);
                    await Task.Delay(300);
                    _ = RollDie(dice4Spot);
                    break;
                case 5:
                    _ = RollDie(dice1Spot);
                    await Task.Delay(300);
                    _ = RollDie(dice2Spot);
                    await Task.Delay(300);
                    _ = RollDie(dice3Spot);
                    await Task.Delay(300);
                    _ = RollDie(dice4Spot);
                    await Task.Delay(300);
                    _ = RollDie(dice5Spot);
                    break;
            }
        }

        public async Task RollDie(Image image)
        {
            for (int i = 0; i < 6; i++)
            {
                int roll = random.Next(1, 5);
                int rotation = random.Next(1, 360);
                switch (roll)
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
                image.Rotation = rotation;
                await Task.Delay(80);
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
