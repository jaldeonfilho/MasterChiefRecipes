using Models;
using Repository;
using Service.Interfaces;

namespace Service.Implementation
{
    public class CommentService : GenericService<CommentDto>, ICommentService
    {
        public CommentService(IGenericRepository<CommentDto> repository)
            : base(repository)
        {
        }

    }
}
