﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlePersonalizado.Controls
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(true)]

    public partial class CardView : ContentView
    {
        public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);
        public static readonly BindableProperty CardDescriptionProperty = BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(CardView), string.Empty);
        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CardView), Color.DarkGray);
        public static readonly BindableProperty CardColorProperty = BindableProperty.Create(nameof(CardColor), typeof(Color), typeof(CardView), Color.White);
        public static readonly BindableProperty IconImageSourceProperty = BindableProperty.Create(nameof(IconImageSource), typeof(ImageSource), typeof(CardView), default(ImageSource));
        public static readonly BindableProperty IconBackgroundColorProperty = BindableProperty.Create(nameof(IconBackgroundColor), typeof(Color), typeof(CardView), Color.LightGray);
        public static readonly BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextC), typeof(Color), typeof(CardView), Color.Black);

        public string CardTitle
        {
            get => (string)GetValue(CardView.CardTitleProperty);
            set => SetValue(CardView.CardTitleProperty, value);
        }

        public string CardDescription
        {
            get => (string)GetValue(CardView.CardDescriptionProperty);
            set => SetValue(CardView.CardDescriptionProperty, value);
        }

        public Color BorderColor
        {
            get => (Color)GetValue(CardView.BorderColorProperty);
            set => SetValue(CardView.BorderColorProperty, value);
        }

        public Color CardColor
        {
            get => (Color)GetValue(CardView.CardColorProperty);
            set => SetValue(CardView.CardColorProperty, value);
        }

        public ImageSource IconImageSource
        {
            get => (ImageSource)GetValue(CardView.IconImageSourceProperty);
            set => SetValue(CardView.IconImageSourceProperty, value);
        }

        public Color IconBackgroundColor
        {
            get => (Color)GetValue(CardView.IconBackgroundColorProperty);
            set => SetValue(CardView.IconBackgroundColorProperty, value);
        }
        public Color TextC
        {
            get => (Color)GetValue(CardView.TextColorProperty);
            set => SetValue(CardView.TextColorProperty, value);
        }
        public CardView()
        {
            InitializeComponent();
        }
    }
}