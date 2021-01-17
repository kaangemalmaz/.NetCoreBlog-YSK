using System.Collections.Generic;
using System.Threading.Tasks;
using YSKProje.Business.Interfaces;
using YSKProje.DataAccess.Interfaces;
using YSKProje.Entities.Concrete;

namespace YSKProje.Business.Concrete
{
    public class CommentManager : GenericManager<Comment>, ICommentService
    {
        private readonly IGenericDal<Comment> _genericDal;
        private readonly ICommentDal _commentDal;

        public CommentManager(IGenericDal<Comment> genericDal, ICommentDal commentDal) : base(genericDal)
        {
            _genericDal = genericDal;
            _commentDal = commentDal;
        }

        public async Task<List<Comment>> GetAllWithSubComments(int blogid, int? parentId)
        {
            return await _commentDal.GetAllWithSubComments(blogid, parentId);
        }
    }
}
