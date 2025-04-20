using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<DiaryEntry> objDiaryEntryList = _db.DiaryEntries.ToList();
            return View(objDiaryEntryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            _db.DiaryEntries.Add(obj); //add new diary entry to the database
            _db.SaveChanges(); // saving changes into the database
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);

            if(diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)
        {
            _db.DiaryEntries.Update(obj); //Update latest diary entry to the database
            _db.SaveChanges(); // saving changes into the database
            return RedirectToAction("Index");
        }

        
        public IActionResult Delete(int? id)
        {
            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Delete(DiaryEntry obj)
        {
            _db.DiaryEntries.Remove(obj); //Remove diary entry to the database
            _db.SaveChanges(); // saving changes into the database
            return RedirectToAction("Index");
        }
    }
}
