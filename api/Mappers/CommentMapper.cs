using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;
using api.Models;

namespace api.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToDto(Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Content = commentModel.Content,
                StockId = commentModel.StockID,
                CreatedOn = commentModel.CreatedOn
            };
        }
    }
}