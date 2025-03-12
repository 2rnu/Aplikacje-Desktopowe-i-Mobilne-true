using QuizClassLibrary;
using QuizClassLibrary.Models;
using System.Collections.ObjectModel;

namespace Quiz.ViewModels
{
    public class QuizViewModel : BindableObject
    {
        private readonly QuizRepository quizRepository;
        private int currentQuestionIndex = 1;
        public Question? CurrentQuestion { get; private set; }
        public List<Answer> Answers { get; private set; } = new();

        public string QuestionLabel => CurrentQuestion?.Question1 ?? "";
        public string Answer1Label => Answers.ElementAtOrDefault(0)?.Answer1 ?? "";
        public string Answer2Label => Answers.ElementAtOrDefault(1)?.Answer1 ?? "";
        public string Answer3Label => Answers.ElementAtOrDefault(2)?.Answer1 ?? "";
        public string Answer4Label => Answers.ElementAtOrDefault(3)?.Answer1 ?? "";

        private bool[] answerRadioButtons = new bool[4];
        public bool Answer1RadioButton { get => answerRadioButtons[0]; set { answerRadioButtons[0] = value; OnPropertyChanged(); } }
        public bool Answer2RadioButton { get => answerRadioButtons[1]; set { answerRadioButtons[1] = value; OnPropertyChanged(); } }
        public bool Answer3RadioButton { get => answerRadioButtons[2]; set { answerRadioButtons[2] = value; OnPropertyChanged(); } }
        public bool Answer4RadioButton { get => answerRadioButtons[3]; set { answerRadioButtons[3] = value; OnPropertyChanged(); } }

        private string result = "";
        public string Result { get => result; set { result = value; OnPropertyChanged(); } }

        private Color resultColor;
        public Color ResultColor { get => resultColor; set { resultColor = value; OnPropertyChanged(); } }

        public Command NextQuestionCommand { get; }
        public Command PreviousQuestionCommand { get; }
        public Command SelectAnswerCommand { get; }
        public Command ResetQuizCommand { get; }

        public QuizViewModel(QuizRepository repository)
        {
            quizRepository = repository;
            NextQuestionCommand = new Command(NextQuestion);
            PreviousQuestionCommand = new Command(PreviousQuestion);
            SelectAnswerCommand = new Command(CheckAnswer);
            ResetQuizCommand = new Command(ResetQuiz);
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            CurrentQuestion = quizRepository.DownloadCurrentQuestion(currentQuestionIndex);
            Answers = quizRepository.DownloadCurrentAnswers(currentQuestionIndex);
            OnPropertyChanged(nameof(QuestionLabel));
            OnPropertyChanged(nameof(Answer1Label));
            OnPropertyChanged(nameof(Answer2Label));
            OnPropertyChanged(nameof(Answer3Label));
            OnPropertyChanged(nameof(Answer4Label));
        }

        private void NextQuestion()
        {
            currentQuestionIndex = (currentQuestionIndex % quizRepository.DownloadQuestionsAmount()) + 1;
            LoadQuestion();
        }

        private void PreviousQuestion()
        {
            currentQuestionIndex = currentQuestionIndex == 1 ? quizRepository.DownloadQuestionsAmount() : currentQuestionIndex - 1;
            LoadQuestion();
        }

        private void CheckAnswer()
        {
            for (int i = 0; i < answerRadioButtons.Length; i++)
            {
                if (answerRadioButtons[i] && Answers.ElementAtOrDefault(i)?.IsCorrect == true)
                {
                    Result = "To prawidłowa odpowiedź!";
                    ResultColor = Colors.Green;
                    return;
                }
            }
            Result = "To nieprawidłowa odpowiedź!";
            ResultColor = Colors.Red;
        }

        private void ResetQuiz()
        {
            currentQuestionIndex = 1;
            Result = "";
            LoadQuestion();
        }
    }
}
