﻿using System;
using System.Collections.Generic;
using YSKProje.Entities.Interfaces;

namespace YSKProje.Entities.Concrete
{
    public class Comment : ITable
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Description { get; set; }
        public DateTime PostedTime { get; set; } = DateTime.Now;

        public int? ParentCommentId { get; set; }
        public Comment ParentComment { get; set; }

        public List<Comment> SubComment { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
