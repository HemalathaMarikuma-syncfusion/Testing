using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matrimony.Views.Registration
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BasicDetail : ContentPage
	{
        public BasicDetail()
        {
            InitializeComponent();

            LoadDefaultProperties();
        }

        private void LoadDefaultProperties()
        {
            pickHeight.SelectedIndex = 8;
            pickWeight.SelectedIndex = 15;
            pickMartialStatus.SelectedIndex = 0;
            pickBodyType.SelectedIndex = 0;
            pickComplexion.SelectedIndex = 2;
        }

        private void BtnSaveBasicDetails_Clicked(object sender, EventArgs e)
        {

        }
    }
}