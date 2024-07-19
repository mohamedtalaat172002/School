using Microsoft.EntityFrameworkCore;

namespace School.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions option) : base(option)
        {

        }

    }
}
