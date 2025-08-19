using DadJokesApp.Models;
using DadJokesApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DadJokesApp.ViewModels
{
    public class DisplayJokesViewModel
    {
        private DadJokeApiService _dadJokeApiService;
        private Joke _dadjoke;

        public Joke DadJoke
        {
            get { return _dadjoke; }
            set { _dadjoke = value; }
        }

        public ICommand GetDadJokeCommand { get; }

        public DisplayJokesViewModel(DadJokeApiService dadJokeApiService)
        {
            _dadJokeApiService = dadJokeApiService;

            GetDadJokeCommand = new Command(GetDadJokes);
        }

        private async void GetDadJokes(object obj)
        {
            await _dadJokeApiService.GetDadJoke();
        }
    }
}
