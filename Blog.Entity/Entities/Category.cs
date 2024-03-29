﻿using Blog.Core.Entities;

namespace Blog.Entity.Entities;

public class Category: EntityBase
{
    public string Name { get; set; }
    public virtual ICollection<Article> Articles { get; set; }

}