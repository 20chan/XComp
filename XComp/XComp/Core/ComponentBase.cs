using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XComp.Core
{
    public abstract class ComponentBase
    {
        public GameObject Owner { get; set; }
    }
}
