using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeBas1.Models;

namespace CodeBas1.Data
{
    public class CodeBas1Context : DbContext
    {
        public CodeBas1Context (DbContextOptions<CodeBas1Context> options)
            : base(options)
        {
        }

        public DbSet<CodeBas1.Models.Student> Student { get; set; }
    }
}
