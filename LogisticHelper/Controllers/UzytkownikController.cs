using LogisticHelper.Models;
using LogisticHelper.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogisticHelper.Controllers
{
    public class UzytkownikController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        // GET: UzytkownikController
        public UzytkownikController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        // GET: BookCoverController

        public IActionResult Index()
        {
            IEnumerable<Uzytkownik> objCoverType = _unitOfWork.Uzytkownik.GetAll();
            return View(objCoverType);
        }

        // GET: UzytkownikController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UzytkownikController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UzytkownikController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UzytkownikController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UzytkownikController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UzytkownikController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
