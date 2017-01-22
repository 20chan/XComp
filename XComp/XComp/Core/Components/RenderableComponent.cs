using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace XComp.Core.Components
{
    public class RenderableComponent : ComponentBase
    {
        public RenderableComponent(GameObject owner) : base(owner)
        {

        }

        public override void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch sb, GameTime gameTime)
        {
            sb.Draw(Owner.Sprite.Texture, Owner.Bound, null, Owner.Sprite.Tint, Owner.Rotation, Vector2.Zero, SpriteEffects.None, Owner.Depth);
        }
    }
}
