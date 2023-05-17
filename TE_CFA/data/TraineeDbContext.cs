using Microsoft.EntityFrameworkCore;
using TE_CFA.Models;

namespace TE_CFA.data
{
    public class TraineeDbContext:DbContext
    {
        public TraineeDbContext(DbContextOptions options):base(options) 
        {
            
        
        }
       public DbSet<Trainee> Trainees { get; set; }
    }
}
