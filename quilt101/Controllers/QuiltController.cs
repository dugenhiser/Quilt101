using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quilt101.Model;
using quilt101.ViewModels;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace quilt101.Controllers
{
    public class QuiltController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IQuiltRepository _quiltRepository;

        public QuiltController(IQuiltRepository quiltRepository, ICategoryRepository categoryRepository)
        {
            _quiltRepository = quiltRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            QuilstListViewModel quiltsListViewModel = new QuilstListViewModel();
            quiltsListViewModel.Quilts = _quiltRepository.Quilts;
            return View(quiltsListViewModel);
        }
    }
}
