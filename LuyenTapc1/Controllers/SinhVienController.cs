using App_class_lib.AllRepos;
using App_class_lib.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LuyenTapc1.Controllers
{
	public class SinhVienController : Controller
	{
		AllRepos<SinhVien> _repos;
		T1Context _context;
		DbSet<SinhVien> SinhViens;
		public SinhVienController()
		{
			_context = new T1Context();
			_repos = new AllRepos<SinhVien>(_context.SinhViens, _context);
		}
		public IActionResult Index()
		{
			var lst = _repos.GetAll();
			return View(lst);
		}

		// GET: SinhVienController/Details/5
		public IActionResult Details(int id)
		{
			return View();
		}

		// GET: SinhVienController/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: SinhVienController/Create
		[HttpPost]
		public IActionResult Create(SinhVien sinhvien)
		{
			try
			{
				sinhvien.Id = Guid.NewGuid();
				_repos.CreateObj(sinhvien);
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: SinhVienController/Edit/5
		public IActionResult Details(dynamic id)
		{
			var GetByID = _repos.GetByID(id);
			return View(GetByID);
		}


		public IActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				var UpdateID = _repos.GetByID(id);
				_repos.UpdateObj(UpdateID);
				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: SinhVienController/Delete/5
		public IActionResult Delete(int id)
		{
			var IdDel = _repos.GetByID(id);
			_repos.DeleteObj(IdDel);
			return View();
		}

		
	}
}
