using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace XComp.Core
{
    public abstract class ComponentBase
    {
        public GameObject Owner { get; set; }

        public ComponentBase(GameObject owner)
        {
            Owner = owner;
        }
    }
}
