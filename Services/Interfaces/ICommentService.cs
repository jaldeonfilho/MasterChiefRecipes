using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ICommentService
    {
        public void AddComment(Comment comment);
        public Comment GetCommentById(int commentId);
        public IEnumerable<Comment> GetAllComments();
        public void UpdateComment(Comment comment);
        public void RemoveComment(int commentId);
    }
}
