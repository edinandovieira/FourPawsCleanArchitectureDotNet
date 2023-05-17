using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;
using FourPawsCleanArchitecture.Domain.Records;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FourPawsCleanArchitecture.Api.Controllers
{
    [Route("v1/categoria")]
    [ApiController]
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public ActionResult<List<Categoria>> GetAll()
        {
            var categorias = _categoriaService.GetAllCategory();
            return Ok(categorias);
        }

        [HttpGet]
        [Route("{codigo:guid}")]
        public ActionResult<Categoria> Get(Guid codigo)
        {
            var categoria = _categoriaService.GetCategory(codigo);
            return Ok(categoria);
        }

        [HttpPost]
        public ActionResult<Categoria> PostCategory(Categoria categoria)
        {
            var Categoria = _categoriaService.CreateCategory(categoria);
            return Ok(categoria);
        }

        [HttpPut]
        [Route("{codigo:guid}")]
        public ActionResult<Categoria> UpdateCategory([FromRoute] Guid codigo, RUpdateCategory rUpdateCategory)
        {
            var newCategoria = _categoriaService.GetCategory(codigo);

            newCategoria.Nome = rUpdateCategory.nome;

            newCategoria = _categoriaService.UpdateCategory(newCategoria);

            return Ok(newCategoria);
        }

        [HttpPost]
        [Route("{id:guid}")]
        public ActionResult<Categoria> RemoveCategory(Categoria categoria)
        {
            var Categoria = _categoriaService.RemoveCategory(categoria);
            return Ok(categoria);
        }
        //// GET: CategoriaController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: CategoriaController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: CategoriaController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: CategoriaController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: CategoriaController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: CategoriaController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: CategoriaController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: CategoriaController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
