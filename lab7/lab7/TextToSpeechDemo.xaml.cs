﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextToSpeechDemo : ContentPage
    {
        public TextToSpeechDemo()
        {
            InitializeComponent();

            var stack = new StackLayout();

            var speak = new Button
            {
                Text = "Hello Forms!",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions= LayoutOptions.CenterAndExpand,

            };
            speak.Clicked += (sender, e) =>
            {
                DependencyService.Get <ITextToSpeech>().Speak("Hello from Xamarin.forms");
            
            };
            stack.Children.Add(speak);

            Content = speak;

        }
    }
}