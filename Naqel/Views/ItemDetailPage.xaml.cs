﻿using BMSBahrain.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BMSBahrain.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}