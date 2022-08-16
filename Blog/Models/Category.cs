using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Models
{
    [Table("[Category]")]
    public class Category : Base
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        [Write(false)]
        public IList<Post> Posts { get; set; }
    }
}
