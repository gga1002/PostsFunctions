using System;
using System.Collections.Generic;
using System.Text;

namespace Supreme
{
    public class Post
    {
        Post()
        {
            PublishDate = DateTime.Today;
        }
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public DateTime PublishDate { get; set; }

    }
}
