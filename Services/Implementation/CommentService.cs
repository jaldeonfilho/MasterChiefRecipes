using Models;
using Repository;
using Service.Interfaces;

namespace Service.Implementation
{
    public class CommentService : GenericService<Comment>, ICommentService
    {
        public CommentService(IGenericRepository<Comment> repository)
            : base(repository)
        {
        }

    }
}
