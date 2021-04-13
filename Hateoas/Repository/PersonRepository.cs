using Hateoas.Models;
using System.Collections.Generic;

namespace Hateoas.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public List<PersonModel> FindAll()
        {
            return new List<PersonModel>
            {
                new PersonModel()
                {
                    Id = 1,
                    Name = "AAAAA"
                },
                new PersonModel()
                {
                    Id = 2,
                    Name = "BBBBB"
                },
                new PersonModel()
                {
                    Id = 3,
                    Name = "CCCCC"
                }
            };
        }
    }
}
