using System.Collections.Generic;
using System.Threading.Tasks;
using YSKProje.Entities.Concrete;

namespace YSKProje.Business.Interfaces
{
    public interface ICommentService : IGenericService<Comment>
    {
        Task<List<Comment>> GetAllWithSubComments(int blogid, int? parentId);
    }
}
