using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be min 5 char long")]
        [MaxLength(200, ErrorMessage = "Title must be max 200 char long")]
        public string Title { get; set;} = string.Empty;

        [Required]
        [MinLength(5, ErrorMessage = "Content must be min 5 char long")]
        [MaxLength(200, ErrorMessage = "Content must be max 200 char long")]
        public string Content { get; set; } = string.Empty;
    }
}