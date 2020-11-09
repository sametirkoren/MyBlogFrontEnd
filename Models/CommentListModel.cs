using System;
using System.Collections.Generic;

namespace MyBlogFrontEnd.Models
{
    public class CommentListModel
    {

        public int Id { get; set; }

        public string AuthorName { get; set; }

        public string AuthorEmail { get; set; }

        public string Description { get; set; }

        public DateTime PostedTime { get; set; } = DateTime.Now;

        public int? ParentCommentId { get; set; }
    

        public List<CommentListModel> SubComments { get; set; }

        public int BlogId { get; set; }
        
    }

    
}