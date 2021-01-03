using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YSKProje.API.Enums;
using YSKProje.API.Models.Blog;
using YSKProje.Business.Interfaces;
using YSKProje.DataAccess.Concrete.EntityFrameworkCore.Context;
using YSKProje.DTO.DTOs.BlogDtos;
using YSKProje.Entities.Concrete;

namespace YSKProje.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : BaseController
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;

        public BlogsController(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }

        // GET: api/Blogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Blog>>> GetBlogs()
        {
            return Ok(_mapper.Map<List<BlogListDto>>(await _blogService.GetAllSortedByPostedTimeAsync()));
        }

        // GET: api/Blogs/5
        [HttpGet("{id}")]
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
    }
}
