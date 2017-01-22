using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace XComp.Core
{
    public abstract class ComponentBase : DrawableGameComponent
    {
        public GameObject Owner { get; set; }

        public ComponentBase(GameObject owner) : base(owner.Game)
        {
            Owner = owner;
        }
    }
}
