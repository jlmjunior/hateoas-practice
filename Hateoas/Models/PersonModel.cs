using Hateoas.Hypermedia;
using Hateoas.Hypermedia.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hateoas.Models
{
    public class PersonModel : ISupportsHyperMedia
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
