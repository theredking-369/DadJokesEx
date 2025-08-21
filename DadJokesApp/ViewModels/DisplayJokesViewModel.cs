using DadJokesApp.Models;
using DadJokesApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DadJokesApp.ViewModels
{
    public class DisplayJokesViewModel : BaseViewModel
    {
        private DadJokeApiService _dadJokeApiService;

        

        private ObservableCollection<Joke> _dadjoke;

        public ObservableCollection<Joke> DadJoke
        {
            get { return _dadjoke; }
            set { _dadjoke = value;

                OnPropertyChanged();

            }
        }

        public ICommand GetDadJokeCommand { get; }

        public DisplayJokesViewModel(DadJokeApiService dadJokeApiService)
        {
            _dadJokeApiService = dadJokeApiService;

            DadJoke = new ObservableCollection<Joke>();

            GetDadJokeCommand = new Command(GetDadJokes);
        }

        private async void GetDadJokes(object obj)
        {
            NetworkAccess accessType = Connectivity.Current.NetworkAccess;
            if (accessType == NetworkAccess.Internet)
            {
                DadJoke.Add(await _dadJokeApiService.GetDadJoke());
            }
        }
    }
}
