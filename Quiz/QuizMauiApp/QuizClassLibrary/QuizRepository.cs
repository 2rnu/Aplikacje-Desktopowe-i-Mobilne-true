using QuizClassLibrary.Models;
using QuizClassLibrary;

public class QuizRepository
{
    private readonly QuizDBContext dbContext;

    public QuizRepository(QuizDBContext context)
    {
        dbContext = context ?? throw new ArgumentNullException(nameof(context));
    }

    public Question? GetCurrentQuestion(int id)
    {
        return dbContext.Questions
            .FirstOrDefault(p => p.Id == id);
    }


    public List<Answer> GetCurrentAnswers(int id)
    {
        return dbContext.Answers
            .Where(p => p.QuestionId == id)
            .ToList();
    }

    public int GetQuestionsAmount()
    {
        return dbContext.Questions.Count();
    }
}