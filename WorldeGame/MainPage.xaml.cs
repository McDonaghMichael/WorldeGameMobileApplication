﻿using System.Text.Json;

namespace WorldeGame
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

           ListOfWords.LoadWordsAsync();

            this.BackgroundColor = Color.FromArgb(DefaultConstants.GetBackgroundColor());

            Button playButton = new Button
            {
                Text = "Play",
                BackgroundColor = Color.FromArgb(DefaultConstants.GetButtonBackgroundColor(2)),
                TextColor = Colors.White,
                FontSize = 20,
                HeightRequest = 60,
                WidthRequest = 500,
                CornerRadius = 10,
                Margin = 5,
                HorizontalOptions = LayoutOptions.Center
            };

            Button howToPlayButton = new Button
            {
                Text = "Help",
                BackgroundColor = Color.FromArgb(DefaultConstants.GetButtonBackgroundColor(1)),
                TextColor = Colors.White,
                FontSize = 20,
                HeightRequest = 60,
                WidthRequest = 250,
                CornerRadius = 10,
                Margin = 5,
                HorizontalOptions = LayoutOptions.Center
            };
    
            Button settingsButton = new Button
            {
                Text = "Settings",
                BackgroundColor = Color.FromArgb(DefaultConstants.GetButtonBackgroundColor(1)),
                TextColor = Colors.White,
                FontSize = 20,
                HeightRequest = 60,
                WidthRequest = 250,
                CornerRadius = 10,
                Margin = 5,
                HorizontalOptions = LayoutOptions.Center
            };

           
            Button creditsButton = new Button
            {
                Text = "Credits",
                BackgroundColor = Color.FromArgb(DefaultConstants.GetButtonBackgroundColor(1)),
                TextColor = Colors.White,
                FontSize = 20,
                HeightRequest = 60,
                WidthRequest = 250,
                CornerRadius = 10,
                Margin = 5,
                HorizontalOptions = LayoutOptions.Center
            };

            playButton.Clicked += PlayButtonClicked;
            settingsButton.Clicked += SettingsButtonClicked;
            howToPlayButton.Clicked += HowToPlayButtonClicked;
            creditsButton.Clicked += CreditsButtonClicked;

            topLevel.Children.Add(playButton);

            middleLevel.Children.Add(howToPlayButton);
            middleLevel.Children.Add(creditsButton);
            middleLevel.Children.Add(settingsButton);
        }

        private async void PlayButtonClicked(object sender, EventArgs e)
        {     
            await Navigation.PushAsync(new GamePage());
        }

        private async void SettingsButtonClicked(object sender, EventArgs e)
        {         
            await Navigation.PushAsync(new SettingsPage());
        }

        private async void HowToPlayButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HowToPlayPage());
        }

        private async void CreditsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreditsPage());
        }



    }
}