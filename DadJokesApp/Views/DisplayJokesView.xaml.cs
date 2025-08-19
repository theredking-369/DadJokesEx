using DadJokesApp.ViewModels;
namespace DadJokesApp.Views;

public partial class DisplayJokesView : ContentPage
{
	public DisplayJokesView(DisplayJokesViewModel vm)
	{
		InitializeComponent();

		BindingContext = 
			vm;
	}
}