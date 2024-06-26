﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLHDotNetCore.GraphqlExample.Features.Blog;

[Table("Tbl_Blog")]
public class BlogModel
{
    [Key]
    public int Blog_Id { get; set; }
    public string Blog_Title { get; set; }
    public string Blog_Author { get; set; }
    public string Blog_Content { get; set; }
}
