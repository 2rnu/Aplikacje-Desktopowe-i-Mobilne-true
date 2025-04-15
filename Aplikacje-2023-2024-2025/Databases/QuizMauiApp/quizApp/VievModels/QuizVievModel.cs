using QuizClassLibrary;
using QuizClassLibrary.Models;
using System.Collections.ObjectModel;

namespace Quiz.ViewModels
{
    public class QuizViewModel : BindableObject
    {
        private readonly QuizRepository? quizRepository;
        private int currentQuestionIndex = 1;
        public Question? CurrentQuestion { get; private set; }
        public List<Answer> Answers { get; private set; } = new();

        public string QuestionLabel => CurrentQuestion?.Question1 ?? "";
        public string AnswerLabel1 => Answers.ElementAtOrDefault(0)?.Answer1 ?? "";
        public string AnswerLabel2 => Answers.ElementAtOrDefault(1)?.Answer1 ?? "";
        public string AnswerLabel3 => Answers.ElementAtOrDefault(2)?.Answer1 ?? "";
        public string AnswerLabel4 => Answers.ElementAtOrDefault(3)?.Answer1 ?? "";

        private bool[] answerRadioButtons = new bool[4];
        public bool AnswerRadiobutton1 { get => answerRadioButtons[0]; set { answerRadioButtons[0] = value; OnPropertyChanged(); } }
        public bool AnswerRadiobutton2 { get => answerRadioButtons[1]; set { answerRadioButtons[1] = value; OnPropertyChanged(); } }
        public bool AnswerRadiobutton3 { get => answerRadioButtons[2]; set { answerRadioButtons[2] = value; OnPropertyChanged(); } }
        public bool AnswerRadiobutton4 { get => answerRadioButtons[3]; set { answerRadioButtons[3] = value; OnPropertyChanged(); } }

        private string result = "";
        public string Result { get => result; set { result = value; OnPropertyChanged(); } }

        private Color? resultColor;
        public Color ResultColor { get => resultColor; set { resultColor = value; OnPropertyChanged(); } }

        public Command? NextQuestionCommand { get; }
        public Command? PreviousQuestionCommand { get; }
        public Command? SelectAnswerCommand { get; }
        public Command? ResetQuizCommand { get; }
        private void LoadQuestion()
        {
            CurrentQuestion = quizRepository.GetCurrentQuestion(currentQuestionIndex);
            Answers = quizRepository.GetCurrentAnswers(currentQuestionIndex);
            OnPropertyChanged(nameof(QuestionLabel));
            OnPropertyChanged(nameof(AnswerLabel1));
            OnPropertyChanged(nameof(AnswerLabel2));
            OnPropertyChanged(nameof(AnswerLabel3));
            OnPropertyChanged(nameof(AnswerLabel4));
        }
        private void NextQuestion()
        {
            currentQuestionIndex = (currentQuestionIndex % quizRepository.GetQuestionsAmount()) + 1;
            LoadQuestion();
        }

        private void PreviousQuestion()
        {
            currentQuestionIndex = currentQuestionIndex == 1 ? quizRepository.GetQuestionsAmount() : currentQuestionIndex - 1;
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
    }
}

