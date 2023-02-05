using Microsoft.EntityFrameworkCore;

namespace Quiz.Models
{
    public partial class QuizDbContext : DbContext
    {
        public QuizDbContext()
        { }
        public QuizDbContext(DbContextOptions<QuizDbContext> options)
            : base(options)
        { }
        public virtual DbSet<Question> Movies { get; set; }
    }
}
