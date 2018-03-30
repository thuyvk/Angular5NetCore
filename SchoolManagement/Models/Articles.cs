using System;
using System.Collections.Generic;

namespace SchoolManagement.Models
{
    public partial class Articles
    {
        public Guid Id { get; set; }
        public Guid? CateId { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime? TimePost { get; set; }
    }
}
