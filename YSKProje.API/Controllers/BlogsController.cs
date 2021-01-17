using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YSKProje.API.CustomFilter;
using YSKProje.API.Enums;
using YSKProje.API.Models.Blog;
using YSKProje.Business.Interfaces;
using YSKProje.DTO.DTOs.BlogDtos;
using YSKProje.DTO.DTOs.CategoryBlogDtos;
using YSKProje.DTO.DTOs.CategoryDtos;
using YSKProje.DTO.DTOs.CommentsDtos;
using YSKProje.Entities.Concrete;

namespace YSKProje.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : BaseController
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;
        private readonly ICommentService _commentService;

        public BlogsController(IBlogService blogService, IMapper mapper, ICommentService commentService)
        {
            _blogService = blogService;
            _mapper = mapper;
            _commentService = commentService;
        }

        // GET: api/Blogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Blog>>> GetBlogs()
        {
            return Ok(_mapper.Map<List<BlogListDto>>(await _blogService.GetAllSortedByPostedTimeAsync()));
        }

        // GET: api/Blogs/5
        [HttpGet("{id}")]
        [ServiceFilter(typeof(ValidId<Blog>))]
        public async Task<ActionResult<Blog>> GetBlog(int id)
        {
            var blog = await _blogService.FindByIdAsync(id);

            if (blog == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<BlogListDto>(blog));
        }

        // PUT: api/Blogs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        [Authorize]
        [ValidModel]
        [ServiceFilter(typeof(ValidId<Blog>))]
        public async Task<IActionResult> PutBlog(int id, [FromForm] BlogUpdateModel blogUpdateModel)
        {
            if (id != blogUpdateModel.Id)
            {
                return BadRequest("geçersiz id");
            }

            var uploadModel = await UploadImage(blogUpdateModel.Image, "image/jpeg");
            if (uploadModel.UploadState == UploadState.success)
            {
                var updatedblog = await _blogService.FindByIdAsync(blogUpdateModel.Id);
                updatedblog.Description = blogUpdateModel.Description;
                updatedblog.ShortDescription = blogUpdateModel.ShortDescription;
                updatedblog.Title = blogUpdateModel.Title;
                updatedblog.ImagePath = uploadModel.NewName;
                await _blogService.UpdateAsync(updatedblog);
            }
            else if (uploadModel.UploadState == UploadState.notExist)
            {
                var updatedblog = await _blogService.FindByIdAsync(blogUpdateModel.Id);
                updatedblog.Description = blogUpdateModel.Description;
                updatedblog.ShortDescription = blogUpdateModel.ShortDescription;
                updatedblog.Title = blogUpdateModel.Title;
                //updatedblog.ImagePath = blogUpdateModel.ImagePath;
                await _blogService.UpdateAsync(updatedblog);
            }
            else
            {
                return BadRequest("Resim kaydedilirken problem oluştu.");
            }

            return NoContent();
        }

        // POST: api/Blogs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [Authorize]
        [ValidModel]
        public async Task<ActionResult<Blog>> PostBlog([FromForm] BlogAddModel blogAddModel)
        {
            var uploadModel = await UploadImage(blogAddModel.Image, "image/jpeg");
            if (uploadModel.UploadState == UploadState.success)
            {
                blogAddModel.ImagePath = uploadModel.NewName;
                await _blogService.AddAsync(_mapper.Map<Blog>(blogAddModel));
            }
            else if (uploadModel.UploadState == UploadState.notExist)
            {
                await _blogService.AddAsync(_mapper.Map<Blog>(blogAddModel));
            }
            else
            {
                return BadRequest("Resim kaydedilirken problem oluştu.");
            }

            return Created("", blogAddModel);
        }

        // DELETE: api/Blogs/5
        [HttpDelete("{id}")]
        [Authorize]
        [ServiceFilter(typeof(ValidId<Blog>))]
        public async Task<ActionResult<Blog>> DeleteBlog(int id)
        {
            var blog = await _blogService.FindByIdAsync(id);
            if (blog == null)
            {
                return NotFound();
            }

            await _blogService.RemoveAsync(blog);

            return blog;
        }

        [HttpPost("[action]")]
        [ValidModel]
        public async Task<IActionResult> AddToCategory(CategoryBlogDto categoryBlogDto)
        {
            await _blogService.AddToCategoryAsync(categoryBlogDto);
            return Created("", categoryBlogDto);
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveFromCategory([FromQuery] CategoryBlogDto categoryBlogDto)
        {
            await _blogService.RemoveFromCategoryAsync(categoryBlogDto);
            return NoContent();
        }

        [HttpGet("[action]/{id}")]
        [ServiceFilter(typeof(ValidId<Category>))]
        public async Task<IActionResult> GetAllByCategoryId(int id)
        {
            return Ok(await _blogService.GetAllByCategoryId(id));
        }

        //api/blogs/1/categories
        //api/blogs/categories/1
        [HttpGet("{id}/[action]")]
        [ServiceFilter(typeof(ValidId<Blog>))]
        public async Task<IActionResult> GetAllCategories(int id)
        {
            return Ok(_mapper.Map<List<CategoryListDto>>(await _blogService.GetCategoriesAsync(id)));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetLastFiveBlog()
        {
            return Ok(_mapper.Map<List<BlogListDto>>(await _blogService.GetLastFiveBlog()));
        }

        [HttpGet("{id}/[action]")]
        public async Task<IActionResult> GetComments([FromRoute] int id, [FromQuery] int? parentid)
        {
            return Ok(_mapper.Map<List<CommentListDto>>(await _commentService.GetAllWithSubComments(id, parentid)));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Search([FromQuery] string s)
        {
            return Ok(_mapper.Map<BlogListDto>(await _blogService.Search(s)));
        }

        [HttpPost("[action]")]
        //[ValidModel]
        public async Task<IActionResult> CommentAdd(CommentAddDto commentAddDto)
        {
            commentAddDto.PostedTime = DateTime.Now;
            await _commentService.AddAsync(_mapper.Map<Comment>(commentAddDto));
            return Created("", commentAddDto);
        }
    }
}
