using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XComp.Core
{
    public class GameObject : DrawableGameComponent
    {
        public Sprite Sprite { get; set; }
        private Vector2 _position;
        public float Rotation { get; set; }

        public float X
        {
            get { return _position.X; }
            set { _position.X = value; }
        }

        public float Y
        {
            get { return _position.Y; }
            set { _position.Y = value; }
        }

        public Vector2 Position => _position;

        public GameObject(Game game, Texture2D texture) : this(game, new Sprite(texture))
        { }

        public GameObject(Game game, Sprite sprite) : base(game)
        {
            Sprite = sprite;
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }
    }
}
