using Models;
using Repository;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public void AddComment(Comment comment)
        {
            _commentRepository.AddComment(comment);
        }

        public Comment GetCommentById(int commentId)
        {
            return _commentRepository.GetCommentById(commentId);
        }

        public IEnumerable<Comment> GetAllComments()
        {
            return _commentRepository.GetAllComments();
        }

        public void UpdateComment(Comment comment)
        {
            _commentRepository.UpdateComment(comment);
        }

        public void RemoveComment(int commentId)
        {
            _commentRepository.RemoveComment(commentId);
        }
    }
}
