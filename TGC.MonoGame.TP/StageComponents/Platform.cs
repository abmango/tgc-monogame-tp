using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using TGC.MonoGame.TP.Geometries;
using TGC.MonoGame.TP.MainCharacter;
using TGC.MonoGame.TP.StageComponents;

internal class Platform : StageComponent
{
    public override void Draw(Matrix view, Matrix projection)
    {
        throw new System.NotImplementedException();
    }

    public override bool Intersects(Character sphere)
    {
        throw new System.NotImplementedException();
    }

    public override void Update(GameTime gameTime)
    {
        throw new System.NotImplementedException();
    }

    protected override GeometricPrimitive CreateModel(GraphicsDevice graphicsDevice, ContentManager content, Vector3 coordinates, Vector3 scale, Matrix rotation)
    {
        throw new System.NotImplementedException();
    }
}
