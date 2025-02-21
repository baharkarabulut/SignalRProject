using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entites;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;
		private readonly IMapper _mapper;

		public ProductController(IProductService productService, IMapper mapper)
		{
			_productService = productService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult ProductList()
		{
			var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
			return Ok(value);
		}

		[HttpPost]
		public ActionResult CreateProduct(CreateProductDto createProductDto)
		{
			_productService.TAdd(new Product()
			{
				ProductName = createProductDto.ProductName,
				Price = createProductDto.Price,
				ProductStatus = createProductDto.ProductStatus,
				Description = createProductDto.Description,
				ImageUrl = createProductDto.ImageUrl
			});
			return Ok("Ürün eklendi.");
		}

		[HttpDelete]
		public ActionResult DeleteProduct(int id)
		{
			var value = _productService.TGetByID(id);
			_productService.TDelete(value);
			return Ok("Ürün silindi.");
		}

		[HttpGet("GetProduct")]
		public IActionResult GetProduct(int id)
		{
			var value = _productService.TGetByID(id);
			return Ok(value);
		}

		[HttpPut]
		public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
		{
			_productService.TUpdate(new Product()
			{
				ProductID = updateProductDto.ProductID,
				ProductName = updateProductDto.ProductName,
				Price = updateProductDto.Price,
				ProductStatus = updateProductDto.ProductStatus,
				Description = updateProductDto.Description,
				ImageUrl = updateProductDto.ImageUrl
			});
			return Ok("Ürün güncellendi.");
		}
	}
}
