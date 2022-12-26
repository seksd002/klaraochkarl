using Microsoft.EntityFrameworkCore;

namespace KlaraKarl.Data
{

    public class KlarakarlDbContext : DbContext
    {
        #region Contructor
        public KlarakarlDbContext(DbContextOptions<KlarakarlDbContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
        #endregion

        #region Public properties
        public DbSet<Person> Person { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(GetPersons());
            base.OnModelCreating(modelBuilder);
        }
        #endregion


        #region Private methods
        private List<Person> GetPersons()
        {
            return new List<Person>
            {
                new Person {Id = 1, Surname = "Erik", Lastname = "Sköld", Email = "erik9996@hotmail.com", Registred=false},
                new Person {Id = 2, Surname = "Linda", Lastname = "Sköld", Email = "lindapinda@hotmail.com", Registred=false},
                new Person {Id = 3, Surname = "Kent", Lastname = "Larsson", Email = "kenta@live.se", Registred=false}


            };
        }
        #endregion
    }
}
