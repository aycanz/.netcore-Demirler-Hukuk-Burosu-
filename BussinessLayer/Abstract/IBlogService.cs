﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog blog);
        void BlogDelete(Blog blog);

        void BlogUpdate(Blog blog);

        List<Blog> GetList();
        Blog GetBlog(int id);

        Blog GetBlogById(int id);
    }
}
