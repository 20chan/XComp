using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XComp.Core
{
    public class GameObject
    {
        private List<ComponentBase> _components;
        private Vector2 _position;

        public Game Game { get; }
        public Sprite Sprite { get; set; }
        public float Rotation { get; set; }
        public int Depth { get; set; } = 0;
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
        public Rectangle Bound => new Rectangle((int)X, (int)Y, Sprite.Width, Sprite.Height);


        public GameObject(Game game, Texture2D texture) : this(game, new Sprite(texture))
        { }

        public GameObject(Game game, Sprite sprite)
        {
            Game = game;
            Sprite = sprite;

            _components = new List<ComponentBase>();
        }

        public virtual void Draw(SpriteBatch sb, GameTime gameTime)
        {
            foreach (var c in _components)
                c.Draw(gameTime);
        }

        public virtual void Update(GameTime gameTime)
        {
            foreach (var c in _components)
                c.Update(gameTime);
        }
    }
}
