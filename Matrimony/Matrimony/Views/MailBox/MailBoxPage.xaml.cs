﻿using Matrimony.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.MailBox
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MailBoxPage : ContentPage
    {
        public MailBoxPage()
        {
            InitializeComponent();
        }

  

        private void ListViewMail_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void ListViewMail_ItemDisappearing(object sender, ItemVisibilityEventArgs e)
        {

        }

        private void TapAccept_Tapped(object sender, EventArgs e)
        {

        }

        private void TapReject_Tapped(object sender, EventArgs e)
        {

        }

        private void SentGesture_Tapped(object sender, EventArgs e)
        {
            ManageSentReceivedSwitch(true);
        }

        private void ReceivedGesture_Tapped(object sender, EventArgs e)
        {
            ManageSentReceivedSwitch(false);
        }

        private void ManageSentReceivedSwitch(bool IsSent)
        { 
            if(IsSent)
            {
                frameReceived.BackgroundColor = Color.White;
                frameSent.BackgroundColor = Color.Green;
                lblReceived.TextColor = Color.Black;
                lblSent.TextColor = Color.White;
            }
            else
            {
                frameReceived.BackgroundColor = Color.Green;
                frameSent.BackgroundColor = Color.White;
                lblReceived.TextColor = Color.White;
                lblSent.TextColor = Color.Black;
            }
        }

        #region SwipeViewGestures

        private bool isOpen = false;

        public bool IsOpen
        {
            get { return isOpen; }
            set
            {
                isOpen = value;

                OnPropertyChanged("IsOpen");
            }
        }

        private void BackArrow_Tapped(object sender, EventArgs e)
        {
            if (!IsOpen)
            {
                MainSwipeView.Open(OpenSwipeItem.LeftItems);
                OpenAnimation();
                IsOpen = true;
            }
            else
            {
                CloseAnimation();
                IsOpen = false;
            }
        }

        private async void OpenAnimation()
        {
            //  await relativeCompletePage.ScaleYTo(0.9, 150, Easing.SinOut);
            IsOpen = true;
            await relativeCompletePage.TranslateTo(350, 0, 280, Easing.SinInOut);
            await relativeCompletePage.RotateTo(-15, 280, Easing.SinOut);
        }

        private async void CloseAnimation()
        {
            await relativeCompletePage.TranslateTo(0, 0, 280, Easing.SinOut);
            await relativeCompletePage.RotateTo(0, 280, Easing.SinOut);
            IsOpen = false;
            //   await relativeCompletePage.ScaleYTo(1, 150, Easing.SinOut);
        }
     

        protected override void OnDisappearing()
        {
            if (IsOpen)
            {
                CloseAnimation();
                IsOpen = false;
            }
        }

        #endregion

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            MainSwipeView.Close();
            CloseAnimation();
        }
    }
}