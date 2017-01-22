using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XComp.Core
{
    public class Level : DrawableGameComponent
    {
        public Camera Camera { get; }
        public Level(Game game, Viewport viewport) : base(game)
        {
            Camera = new Camera(viewport);
        }
    }
}
