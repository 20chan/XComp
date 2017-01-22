using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XComp.Core
{
    public class GameObject
    {
        public Game Game { get; }
        public Sprite Sprite { get; set; }
        private Vector2 _position;
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
        public Rectangle Bound { get { throw new System.NotImplementedException(); } }

        public GameObject(Game game, Texture2D texture) : this(game, new Sprite(texture))
        { }

        public GameObject(Game game, Sprite sprite)
        {
            Game = game;
            Sprite = sprite;
        }
    }
}
