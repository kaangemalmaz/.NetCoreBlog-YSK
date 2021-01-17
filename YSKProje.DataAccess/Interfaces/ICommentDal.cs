using System.Collections.Generic;
using System.Threading.Tasks;
using YSKProje.Entities.Concrete;

namespace YSKProje.DataAccess.Interfaces
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        Task<List<Comment>> GetAllWithSubComments(int blogid, int? parentId);
    }
}
