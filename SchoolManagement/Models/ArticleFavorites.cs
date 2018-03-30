using System;
using System.Collections.Generic;

namespace SchoolManagement.Models
{
    public partial class ArticleFavorites
    {
        public Guid Id { get; set; }
        public Guid? ArticleId { get; set; }
        public Guid? UserId { get; set; }
    }
}
