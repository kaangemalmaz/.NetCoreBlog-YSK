using System;
using System.Collections.Generic;
using YSKProje.DTO.Interfaces;

namespace YSKProje.DTO.DTOs.CommentsDtos
{
    public class CommentListDto : IDto
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Description { get; set; }
        public DateTime PostedTime { get; set; } = DateTime.Now;
        public int? ParentCommentId { get; set; }
        public List<CommentListDto> SubComment { get; set; }
        public int BlogId { get; set; }
    }
}
