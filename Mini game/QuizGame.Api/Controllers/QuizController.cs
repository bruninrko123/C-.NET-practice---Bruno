using Microsoft.AspNetCore.Mvc;
using QuizGame.Api.Services;

namespace QuizGame.Api.Controllers;

[ApiController]
[Route("api/quiz")]
public class QuizController : ControllerBase
{
    private readonly QuizService _quizService;

    public QuizController(QuizService quizService)
    {
        _quizService = quizService;
    }

    [HttpGet("question")]
    public IActionResult GetQuestion()
    {
        var question = _quizService.GetRandomQuestion();
        return Ok(question);
    }

    [HttpPost("answer")]
    public IActionResult submitAnswer(int questionId, int selectedIndex)
    {
        var IsCorrect = _quizService.CheckAnswer(questionId, selectedIndex);
        return Ok(new { correct = IsCorrect });
    }
}