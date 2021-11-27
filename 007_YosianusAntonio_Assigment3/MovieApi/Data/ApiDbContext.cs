using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace MovieApi.Data{
    public class ApiDbContext: IdentityDbContext{
        public virtual DbSet<MovieData> Movies { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options): base(options){
            
        }
    }
}