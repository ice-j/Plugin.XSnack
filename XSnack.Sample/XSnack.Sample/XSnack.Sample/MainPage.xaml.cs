using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XSnack.Sample
{
    public partial class MainPage : ContentPage
	{
        public ICommand DisplaySnackbarCommand => new Command(async () => await Plugin.XSnack.CrossXSnack.Current.ShowMessage(messageEntry.Text, Convert.ToInt32(Math.Round(durationStepper.Value))));


        public MainPage()
		{
			InitializeComponent();
            BindingContext = this;
		}
	}
}
