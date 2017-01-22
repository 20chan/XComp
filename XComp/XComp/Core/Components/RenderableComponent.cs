using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XComp.Core.Components
{
    public class RenderableComponent : ComponentBase
    {
        public SpriteBatch SpriteBatch { get; set; }
        public RenderableComponent(GameObject owner, SpriteBatch sb) : base(owner)
        {
            SpriteBatch = sb;
        }

        public override void Draw(GameTime gameTime)
        {
            SpriteBatch.Draw(Owner.Sprite.Texture, Owner.Bound, null, Owner.Sprite.Tint, Owner.Rotation, Vector2.Zero, SpriteEffects.None, Owner.Depth);
            base.Draw(gameTime);
        }
    }
}
