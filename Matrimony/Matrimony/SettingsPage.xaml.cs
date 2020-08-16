using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
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
        private void SwipeBackGround_Tapped(object sender, EventArgs e)
        {
            MainSwipeView.Close();
            CloseAnimation();
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
    }
}