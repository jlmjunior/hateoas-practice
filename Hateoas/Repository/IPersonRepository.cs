using Hateoas.Models;
using System.Collections.Generic;

namespace Hateoas.Repository
{
    public interface IPersonRepository
    {
        public List<PersonModel> FindAll();
    }
}
