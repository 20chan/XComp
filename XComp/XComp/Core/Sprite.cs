using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XComp.Core
{
    public class Sprite
    {
        private Texture2D Texture { get; set; }
        public Color Tint { get; set; }

        public Sprite(Texture2D texture)
        {
            Texture = texture;
            Tint = Color.White;
        }
    }
}
