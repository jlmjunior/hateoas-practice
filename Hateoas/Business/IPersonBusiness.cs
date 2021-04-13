using Hateoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hateoas.Business
{
    public interface IPersonBusiness
    {
        List<PersonModel> FindAll();
    }
}
