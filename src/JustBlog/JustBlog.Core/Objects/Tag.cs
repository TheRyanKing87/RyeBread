﻿#region Usings
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#endregion

namespace RyeBread.Core.Objects
{
  /// <summary>
  /// Represents a tag that is labelled on a post.
  /// </summary>
  public class Tag
  {
    public virtual int Id
    { get; set; }

    [Required(ErrorMessage = "Name: Field is required")]
    [StringLength(500, ErrorMessage = "Name: Length should not exceed 500 characters")]
    public virtual string Name
    { get; set; }

    [Required(ErrorMessage = "UrlSlug: Field is required")]
    [StringLength(500, ErrorMessage = "UrlSlug: Length should not exceed 500 characters")]
    public virtual string UrlSlug
    { get; set; }

    public virtual string Description
    { get; set; }

    [JsonIgnore]
    public virtual IList<Post> Posts
    { get; set; }
  }
}
