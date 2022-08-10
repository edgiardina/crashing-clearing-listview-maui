namespace MauiApp2;

public partial class MainPage : ContentPage
{
	MainPageViewModel ViewModel;

    public MainPage()
	{
		InitializeComponent();

        ViewModel = new MainPageViewModel();
        ViewModel.Players = new System.Collections.ObjectModel.ObservableCollection<Player> { 
			new Player { Name = "Steve Player", Rank = 1 },
            new Player { Name = "Steve Player2", Rank = 2 },
            new Player { Name = "Steve Player3", Rank = 3 },
            new Player { Name = "Steve Player4", Rank = 4 },
            new Player { Name = "Steve Player5", Rank = 5 },

        };

		this.BindingContext = ViewModel;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        ViewModel.Players.Clear();

    }
}

