using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace api.Models
{
    public class Comment
    {
        public int? StockID { get; set; }
        public Stock? stock { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }= string.Empty;
        public string Content { get; set; }=string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public string CreatedBy { get; set; }= string.Empty;

        internal object ToCommentDto()
        {
            throw new NotImplementedException();
        }
    }
}