using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.DataAccess.Concrete.EntityFrameworkCore.Context;
using YSKProje.DataAccess.Interfaces;
using YSKProje.Entities.Concrete;

namespace YSKProje.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCommentRepository : EfGenericRepository<Comment>, ICommentDal
    {
        public async Task<List<Comment>> GetAllWithSubComments(int blogid, int? parentId)
        {
            List<Comment> result = new List<Comment>();
            await GetComments(blogid, parentId, result);
            return result;
        }

        private async Task GetComments(int blogid, int? parentId, List<Comment> result)
        {/*Burayı debuga alıp denenecek.*/
            using var context = new UdemyBlogContext();
            var comments = await context.Comments.Where(i => i.BlogId == blogid && i.ParentCommentId == parentId).OrderByDescending(i => i.PostedTime).ToListAsync();
            if (comments.Count > 0)
            {
                foreach (var comment in comments)
                {
                    if (comment.SubComment == null)
                        comment.SubComment = new List<Comment>();

                    await GetComments(comment.BlogId, comment.Id, comment.SubComment);

                    if (!result.Contains(comment))
                    {
                        result.Add(comment);
                    }
                }
            }
        }
    }
}
