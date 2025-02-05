using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace w
{
    public class QuizViewModel : INotifyPropertyChanged
    {
        private int _index;
        private string _selectedAnswer;
        private string _feedback;

        public ObservableCollection<Question> Questions { get; } = new()
        {
            new("Co oznacza skrót OOP?", new[]{"Programowanie Obiektowe", "Procesor Operacyjny", "Opcja Optymalizacji", "Organizacja Operacji"}, "Programowanie Obiektowe"),
            new("Który język programowania jest kompilowany?", new[]{"Python", "JavaScript", "C#", "HTML"}, "C#"),
            new("Co to jest algorytm?", new[]{"Zestaw instrukcji", "Język programowania", "Baza danych", "System operacyjny"}, "Zestaw instrukcji"),
            new("Jaki system operacyjny jest open-source?", new[]{"Windows", "Linux", "MacOS", "iOS"}, "Linux")
        };

        public Question CurrentQuestion => Questions[_index];

        public string SelectedAnswer
        {
            get => _selectedAnswer;
            set
            {
                if (_selectedAnswer != value)
                {
                    _selectedAnswer = value;
                    OnPropertyChanged(nameof(SelectedAnswer));
                }
            }
        }

        public string Feedback
        {
            get => _feedback;
            set
            {
                if (_feedback != value)
                {
                    _feedback = value;
                    OnPropertyChanged(nameof(Feedback));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public ICommand NextCommand => new Command(() =>
        {
            if (_index < Questions.Count - 1)
            {
                _index++;
                SelectedAnswer = null;
                Feedback = "";
                OnPropertyChanged(nameof(CurrentQuestion));
            }
        });

        public ICommand PreviousCommand => new Command(() =>
        {
            if (_index > 0)
            {
                _index--;
                SelectedAnswer = null;
                Feedback = "";
                OnPropertyChanged(nameof(CurrentQuestion));
            }
        });

        public ICommand CheckAnswerCommand => new Command(() =>
        {
            if (SelectedAnswer != null && SelectedAnswer.Equals(CurrentQuestion.CorrectAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Feedback = "Poprawna odpowiedź!";
            }
            else
            {
                Feedback = "Błędna odpowiedź.";
            }
        });

        public ICommand ResetCommand => new Command(() =>
        {
            SelectedAnswer = null;
            Feedback = "";
            OnPropertyChanged(nameof(SelectedAnswer));
            OnPropertyChanged(nameof(Feedback));
        });
    }

    public record Question(string Text, string[] Answers, string CorrectAnswer);

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new QuizViewModel();
        }
    }
}
