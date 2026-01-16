using QuizGame.Api.Models;

namespace QuizGame.Api.Services;

public class QuizService
{
    private readonly List<Question> _questions = new()
    {
        new Question
        {
             Id = 1,
            Text = "What does HTML stand for?",
            Options = new List<string>
            {
                "Hyper Trainer Marking Language",
                "Hyper Text Markup Language",
                "High Text Machine Language",
                "Hyper Text Markdown Language"
            },
            CorrectOptionIndex = 1
        }
    };



    public Question GetRandomQuestion()
    {
        return _questions[0];
    }


public bool CheckAnswer(int questionId, int selectedIndex)
    {
        var question = _questions.First(q => q.Id == questionId);
        return question.CorrectOptionIndex == selectedIndex;
    }   
};