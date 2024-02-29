using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp29Blog.Models;

namespace WebApp29Blog.Data
{
    public class WebBlogDbContext : DbContext
    {
        public WebBlogDbContext (DbContextOptions<WebBlogDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp29Blog.Models.AdminInfo> AdminInfo { get; set; } = default!;

        public DbSet<WebApp29Blog.Models.BlogInfo>? BlogInfo { get; set; }

        public DbSet<WebApp29Blog.Models.EmpInfo>? EmpInfo { get; set; }
    }
}
