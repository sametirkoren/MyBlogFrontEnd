using System;
namespace MyBlogFrontEnd.Models
{
    public class CommentAddModel
    {
        

        public string AuthorName { get; set; }

        public string AuthorEmail { get; set; }

        public string Description { get; set; }

        public DateTime PostedTime { get; set; } = DateTime.Now;

        public int? ParentCommentId { get; set; }
    

     

        public int BlogId { get; set; }
    }
}