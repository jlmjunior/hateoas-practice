using Hateoas.Hypermedia.Abstract;
using System.Collections.Generic;

namespace Hateoas.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
