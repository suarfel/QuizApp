using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using QuizApp.Areas.Identity.Data;
using QuizApp.Data;
using QuizApp.Models.Domain;
using QuizApp.Models.ViewModels;



namespace QuizApp.Controllers;
[Authorize]
public class QuizController : Controller
{
    private readonly UserManager<User> _userManager;
    private readonly QuizAppContext _db;

    public QuizController(UserManager<User> userManager, QuizAppContext quizAppDbContext)
    {
        _userManager = userManager;
        _db = quizAppDbContext;
    }



    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var userId = _userManager.GetUserId(this.User);
        ViewData["UserID"] = _userManager.GetUserId(this.User);
        var user = await _userManager.GetUserAsync(this.User);
        var userRole = await _userManager.GetRolesAsync(user);
        ViewData["UserRole"] = userRole.FirstOrDefault();
        return View(await _db.Quizzes.ToListAsync());
    }
    [HttpGet]
    public ActionResult Create()
    {
        return View();
    }

    [HttpGet]

    public async Task<IActionResult> Result()
    {
        var userId = _userManager.GetUserId(this.User);
        var answerModels = await _db.Set<AnswerModel>()
        .Where(a => a.UserID == userId)
        .ToListAsync();
        return View(answerModels);
    }


    [HttpPost]
    public ActionResult Create([Bind("Id", "Title,Description")] Quiz quiz)
    {
        _db.Quizzes.Add(quiz);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }



    // GET: Quiz/Edit/5
    [HttpGet]
    public ActionResult Edit(int? id)
    {
        if (id == null)
        {
            return new StatusCodeResult((int)HttpStatusCode.BadRequest);
        }
        Quiz quiz = _db.Quizzes.Find(id);
        if (quiz == null)
        {
            return NotFound();
        }
        return View(quiz);
    }

    // POST: Quiz/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit([Bind("Id,Title,Description")] Quiz quiz)
    {

        _db.Entry(quiz).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Index");

    }

    [HttpGet]
    // GET: Movies/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var quiz = await _db.Quizzes
            .FirstOrDefaultAsync(m => m.Id == id);
        if (quiz == null)
        {
            return NotFound();
        }

        var answerModels = await _db.Set<AnswerModel>()
        .Where(a => a.QuizId == quiz.Id)
        .ToListAsync();

        var statQuizModel = new StatQuizModel
        {
            Quiz = quiz,
            AnswerModels = answerModels
        };

        return View(statQuizModel);
    }


    public async Task<IActionResult> Delete(int? id)
    {

        if (id == null)
        {
            return NotFound();
        }

        var movie = await _db.Quizzes
            .FirstOrDefaultAsync(m => m.Id == id);
        if (movie == null)
        {
            return NotFound();
        }

        return View(movie);
    }

    // POST: Movies/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var quiz = await _db.Quizzes.FindAsync(id);
        if (quiz != null)
        {
            _db.Quizzes.Remove(quiz);
        }

        await _db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }


    [HttpGet]
    public async Task<IActionResult> Show(int Id)
    {
        var viewModel = new QuizViewModel
        {
            Questions = await _db.Set<Question>()
        .Where(qi => qi.QuizId == Id)
        .Include(c => c.Choices)
        .ToListAsync(),
            Question = new Question(),
            QuizId = Id

        };

        var userId = _userManager.GetUserId(this.User);
        ViewData["UserID"] = _userManager.GetUserId(this.User);
        var user = await _userManager.GetUserAsync(this.User);
        var userRole = await _userManager.GetRolesAsync(user);
        ViewData["UserRole"] = userRole.FirstOrDefault();

        return View(viewModel);
    }


    [HttpPost]
    public ActionResult AddQuestion([Bind("Id ,QuizId, Text")] Question question)
    {

        _db.Questions.Add(question);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> AddChoice(int id)
    {
        var question = _db.Set<Question>()
                 .Where(q => q.Id == id)
               .Include(c => c.Choices)
               .FirstOrDefault();

        var viewModel = new QuestionViewModel
        {
            Question = question,

            Choice = new Choice(),
            Choices = question.Choices
        };
        return View(viewModel);


    }


    [HttpPost]
    public async Task<ActionResult> AddChoice([Bind("Id ,QuestionId, Text")] Choice choice)
    {

        _db.Choices.Add(choice);
        _db.SaveChanges();

        var question = await _db.Questions.FindAsync(choice.QuestionId);

        return RedirectToAction("Show", new { Id = question.QuizId });
    }

    [HttpGet]
    public async Task<IActionResult> AddAnswer(int id)
    {
        var question = _db.Set<Question>()
                 .Where(q => q.Id == id)
               .Include(c => c.Choices)
               .FirstOrDefault();

        var viewModel = new ChoiceViewModel
        {
            Question = question
        };

        return View(viewModel);
        // return RedirectToAction("Show");
    }

    [HttpPost]
    public async Task<IActionResult> AddAnswer(int AnswerId, int QuestionId)
    {
        var choice = await _db.Choices.FindAsync(AnswerId);
        choice.IsCorrect = true;
        _db.Entry(choice).State = EntityState.Modified;
        _db.SaveChanges();

        var question = await _db.Questions.FindAsync(QuestionId);
        return RedirectToAction("Show", new { Id = question.QuizId });

    }

    [HttpGet]
    public ActionResult ShowResult(string data)
    {
        var decodedData = System.Web.HttpUtility.UrlDecode(data);
        var responseData = JsonConvert.DeserializeObject<string>(decodedData);


        // await _db.Questions.AddAsync(new Question{QuizId = 1,Text="sdfjd"});
        @ViewData["result"] = responseData;

        return View();
    }

    [HttpPost]
    public async Task<string> AnswerResult([FromBody] List<AnswerViewModel> answers)
    {

        var userId = _userManager.GetUserId(this.User);
        var userEmail = _userManager.GetUserName(this.User);
        var question = await _db.Questions.FindAsync(answers[0].QuestionId);



        var questions = await _db.Set<Question>()
        .Where(q => q.QuizId == question.QuizId)
        .ToListAsync();

        var total = 0;
        // Process submitted answers
        foreach (var answer in answers)
        {

            var choice = await _db.Choices.FindAsync(answer.AnswerId);
            if (choice.IsCorrect)
            {
                total += 1;
            }
        }

        await _db.AnswerModels.AddAsync(new AnswerModel { UserID = userId, UserEmail= userEmail, QuizId = question.QuizId, Total = total, TotalQuestions = questions.Count() });
        _db.SaveChanges();

        return total.ToString() + " / " + questions.Count().ToString();

    }


}

