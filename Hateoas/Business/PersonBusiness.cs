using Hateoas.Models;
using Hateoas.Repository;
using System.Collections.Generic;

namespace Hateoas.Business
{
    public class PersonBusiness : IPersonBusiness
    {
        private readonly IPersonRepository _repository;

        public PersonBusiness(IPersonRepository repository)
        {
            _repository = repository;
        }

        public List<PersonModel> FindAll()
        {
            return _repository.FindAll();
        }
    }
}
