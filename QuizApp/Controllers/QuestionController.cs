using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizApp.Data;
using QuizApp.Models.Domain;


namespace QuizApp.Controllers;

public class QuestionController : Controller
{
    private readonly QuizAppContext _db;
    public QuestionController(QuizAppContext quizAppDbContext)
    {
        _db = quizAppDbContext;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return View(await _db.Questions.ToListAsync());
    }



    [HttpGet]
    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Add([Bind("Id", "Title,Description")] Question question)
    {
        _db.Questions.Add(question);
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

        return View(quiz);
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
}
