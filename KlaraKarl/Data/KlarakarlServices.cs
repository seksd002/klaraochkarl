using Microsoft.EntityFrameworkCore;

namespace KlaraKarl.Data
{
    public class KlarakarlServices
    {
        #region Private members
        private KlarakarlDbContext dbContext;
        #endregion

        #region Constructor
        public KlarakarlServices(KlarakarlDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// This method returns the list of product
        /// </summary>
        /// <returns></returns>
        public async Task<List<Person>> GetPersonAsync()
        {
            return await dbContext.Person.ToListAsync();
        }
        public async Task<List<Person>> GetValidPersonsAsync(string email)
        {

            return await dbContext.Person.Where(x => x.Email == email).ToListAsync();
        }

        /// <summary>
        /// This method add a new product to the DbContext and saves it
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Person> AddPersonAsync(Person person)
        {
            try
            {
                dbContext.Person.Add(person);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return person;
        }

        /// <summary>
        /// This method update and existing product and saves the changes
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Person> UpdatePersonAsync(Person person)
        {
            try
            {
                var personExist = dbContext.Person.FirstOrDefault(p => p.Id == person.Id);
                if (personExist != null)
                {
                    dbContext.Update(person);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return person;
        }
        public async Task<Person> SetPersonForAccept(Person person )
        {
            try
            {
                var personExist = dbContext.Person.FirstOrDefault(p => p.Id == person.Id);
                if (personExist != null)
                {
                    person.Registred = true;
                    dbContext.Update(person);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return person;
        }
        
        /// <summary>
        /// This method removes and existing product from the DbContext and saves it
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task DeletePersonAsync(Person product)
        {
            try
            {
                dbContext.Person.Remove(product);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
