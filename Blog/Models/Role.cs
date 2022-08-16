using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Models
{
    [Table("[Role]")]
    public class Role : Base
    {
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
