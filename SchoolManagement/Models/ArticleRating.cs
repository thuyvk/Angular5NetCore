using System;
using System.Collections.Generic;

namespace SchoolManagement.Models
{
    public partial class ArticleRating
    {
        public Guid Id { get; set; }
        public Guid? ArticleId { get; set; }
        public int? Point { get; set; }
    }
}
