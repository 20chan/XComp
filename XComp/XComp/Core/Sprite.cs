using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XComp.Core
{
    public class Sprite
    {
        public Texture2D Texture { get; set; }
        public Color Tint { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public Sprite(Texture2D texture)
        {
            Texture = texture;
            Tint = Color.White;

            Width = texture.Width;
            Height = texture.Height;
        }
    }
}
