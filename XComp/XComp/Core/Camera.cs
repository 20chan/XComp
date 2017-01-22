using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XComp.Core
{
    public class Camera
    {
        private Vector2 _position;

        public Rectangle Bounds { get; set; }
        public float Zoom { get; set; }
        public float Rotation { get; set; }
        public Vector2 Position => _position;
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

        public Camera(Viewport viewport)
        {
            _position = Vector2.Zero;
            Bounds = viewport.Bounds;
            Zoom = 1;
            Rotation = 0;
        }

        public Matrix GetTransform()
        {
            return Matrix.CreateTranslation(new Vector3(-X, -Y, 0)) *
                Matrix.CreateRotationZ(Rotation) *
                Matrix.CreateScale(Zoom) *
                Matrix.CreateTranslation(new Vector3(Bounds.Width * 0.5f, Bounds.Height * 0.5f, 0f));
        }
    }
}
