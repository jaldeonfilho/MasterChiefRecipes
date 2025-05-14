using Repository.Context;
using Repository.Interfaces;

namespace Repository.Implementation
{
    public class CommentRepository : GenericRepository<CommentRepository>, ICommentRepository
    {
        public CommentRepository(DbContextRecipe context)
           : base(context) { }

    }
}
