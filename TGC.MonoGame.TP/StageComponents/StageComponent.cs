using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using TGC.MonoGame.TP.Geometries;
using TGC.MonoGame.TP.MainCharacter;

namespace TGC.MonoGame.TP.StageComponents
{
    abstract class StageComponent
    {
        protected BoundingBox Box;
        protected Vector3 Position;
        protected GeometricPrimitive Model;
        protected GraphicsDevice graphics;
        protected ContentManager contentMgr;
        protected const float DefaultSize = 25f;


        public abstract void Update(GameTime gameTime);

        public abstract void Draw(Matrix view, Matrix projection);

        public abstract bool Intersects(Character sphere);
    }
}
