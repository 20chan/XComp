using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XComp.Core
{
    public class Level
    {
        public Game Game { get; }
        private SpriteBatch _spriteBatch;
        public Camera Camera { get; }

        private List<GameObject> _gameObjects;

        public Level(Game game, Viewport viewport)
        {
            Game = game;
            Camera = new Camera(viewport);
            _gameObjects = new List<GameObject>();
        }

        public void LoadContent()
        {
            _spriteBatch = new SpriteBatch(Game.GraphicsDevice);
        }

        public void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin(SpriteSortMode.BackToFront, null, null, null, null, null, Camera.GetTransform());

            _spriteBatch.End();
        }

        public void Update(GameTime gameTime)
        {

        }
    }
}
