using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using YSKProje.API.CustomFilter;
using YSKProje.Business.Interfaces;
using YSKProje.Business.Tools.LogTool;
using YSKProje.DTO.DTOs.CategoryDtos;
using YSKProje.Entities.Concrete;

namespace YSKProje.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        private readonly ICustomLogger _customLogger;

        public CategoriesController(IMapper mapper, ICategoryService categoryService, ICustomLogger customLogger)
        {
            _mapper = mapper;
            _categoryService = categoryService;
            _customLogger = customLogger;
        }


        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryListDto>>> GetCategories()
        {
            return Ok(_mapper.Map<List<CategoryListDto>>(await _categoryService.GetAllSortedByIdAsync()));
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        [ServiceFilter(typeof(ValidId<Category>))]
        public async Task<ActionResult<CategoryListDto>> GetCategory(int id)
        {
            var category = await _categoryService.FindByIdAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CategoryListDto>(category));
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        [Authorize]
        [ValidModel]
        [ServiceFilter(typeof(ValidId<Category>))]
        public async Task<IActionResult> PutCategory(int id, CategoryUpdateDto categoryUpdateDto)
        {
            if (id != categoryUpdateDto.Id)
            {
                return BadRequest();
            }

            await _categoryService.UpdateAsync(_mapper.Map<Category>(categoryUpdateDto));



            return NoContent();
        }

        // POST: api/Categories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [Authorize]
        [ValidModel]
        public async Task<ActionResult<Category>> PostCategory(CategoryAddDto categoryAddDto)
        {
            await _categoryService.AddAsync(_mapper.Map<Category>(categoryAddDto));

            return Created("", categoryAddDto);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        [Authorize]
        [ServiceFilter(typeof(ValidId<Category>))]
        public async Task<ActionResult<Category>> DeleteCategory(int id)
        {
            var category = await _categoryService.FindByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            await _categoryService.RemoveAsync(category);

            return NoContent();
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetWithBlogsCount()
        {
            var categories = await _categoryService.GetAllCategoryWithBlogsCount();
            List<CategoryWithBlogsCountDto> listdto = new List<CategoryWithBlogsCountDto>();
            foreach (var cat in categories)
            {
                CategoryWithBlogsCountDto dto = new CategoryWithBlogsCountDto();
                dto.BlogsCount = cat.categoryBlogs.Count;
                dto.Id = cat.Id;
                dto.Name = cat.Name;
                listdto.Add(dto);
            }

            return Ok(listdto);
        }


        [Route("/Error")]
        public IActionResult Error()
        {
            var errorInfo = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            _customLogger.LogError($"\n Hatanın oluştuğu yer: {errorInfo.Path} \n Hata Mesajı : {errorInfo.Error.Message} \n Stack Trace : {errorInfo.Error.StackTrace}");
            return Problem("Bir hata oluştu en kısa zamanda düzeltilecektir");
        }
    }
}
