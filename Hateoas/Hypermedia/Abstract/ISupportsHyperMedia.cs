using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hateoas.Hypermedia.Abstract
{
    public interface ISupportsHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
