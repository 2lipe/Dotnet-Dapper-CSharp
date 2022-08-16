using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Models
{
    [Table("[Post]")]
    public class Post : Base
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
}
