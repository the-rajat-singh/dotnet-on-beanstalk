using Microsoft.AspNetCore.Mvc;
using FeedbackApp.Models;

namespace FeedbackApp.Controllers;

public class FeedbackController : Controller
{
    static List<Feedback> feedbacks = new();

    public IActionResult Index()
    {
        return View(feedbacks);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Feedback feedback)
    {
        feedbacks.Add(feedback);
        return RedirectToAction("Index");
    }
}

