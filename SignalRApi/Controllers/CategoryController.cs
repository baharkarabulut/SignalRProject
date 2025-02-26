using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entites;


namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryService _categoryService;
		private readonly IMapper _mapper;

		public CategoryController(ICategoryService categoryService, IMapper mapper)
		{
			_categoryService = categoryService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult CategoryList()
		{
			var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
			return Ok(value);
		}

		[HttpPost]
		public ActionResult CreateCategory(CreateCategoryDto createCategoryDto) 
		{
			_categoryService.TAdd(new Category()
			{
				Name = createCategoryDto.Name,
				Status = createCategoryDto.Status
			});
			return Ok("Kategori eklendi.");
		}

		[HttpDelete]
		public ActionResult DeleteCategory(int id)
		{
			var value = _categoryService.TGetByID(id);
			_categoryService.TDelete(value);
			return Ok("Kategori silindi.");
		}

		[HttpGet("GetCategory")]
		public IActionResult GetCategory(int id)
		{
			var value = _categoryService.TGetByID(id);
			return Ok(value);
		}

		[HttpPut]
		public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
		{
			_categoryService.TUpdate(new Category()
			{
				CategoryID = updateCategoryDto.CategoryID,
				Status = updateCategoryDto.Status,
				Name = updateCategoryDto.Name
			});
			return Ok("Kategori güncellendi.");
		}
	}
}
