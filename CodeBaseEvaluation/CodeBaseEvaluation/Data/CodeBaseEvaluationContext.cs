using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeBaseEvaluation.Models;

namespace CodeBaseEvaluation.Data
{
    public class CodeBaseEvaluationContext : DbContext
    {
        public CodeBaseEvaluationContext (DbContextOptions<CodeBaseEvaluationContext> options)
            : base(options)
        {
        }

        public DbSet<CodeBaseEvaluation.Models.Employee> Employee { get; set; }
    }
}
