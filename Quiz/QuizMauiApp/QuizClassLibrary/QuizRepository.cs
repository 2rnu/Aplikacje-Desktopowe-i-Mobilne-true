using QuizClassLibrary.Models;
using QuizClassLibrary;

public class QuizRepository
{
    private readonly QuizDBContext dbContext;

    public QuizRepository(QuizDBContext context) // Wstrzykiwanie zależności
    {
        dbContext = context ?? throw new ArgumentNullException(nameof(context));
    }

    public Question? DownloadCurrentQuestion(int id)
    {
        return dbContext.Questions
            .FirstOrDefault(p => p.Id == id);
    }


    public List<Answer> DownloadCurrentAnswers(int id)
    {
        return dbContext.Answers
            .Where(p => p.QuestionId == id)
            .ToList();
    }

    public int DownloadQuestionsAmount()
    {
        return dbContext.Questions.Count();
    }
}
