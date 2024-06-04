using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using TGC.MonoGame.TP.Geometries;
using TGC.MonoGame.TP.MainCharacter;
using TGC.MonoGame.TP.StageComponents;

internal class Checkpoint : StageComponent
{
    Vector3 RespawnPosition;
    float RespawnYaw;

    public Checkpoint(GraphicsDevice graphicsDevice, ContentManager content, Vector3 center, Vector3 scale, float yaw)
    {
        graphics = graphicsDevice;
        contentMgr = content;
        Position = center;
        RespawnPosition = center;
        RespawnYaw = yaw;

        Vector3 min = center - scale;
        Vector3 max = center + scale;
        Box = new BoundingBox(min, max);

        Model = CreateModel(graphicsDevice, content, center, scale, rotation: Matrix.Identity);
    }

    public override void Update(GameTime gameTime)
    {
        // TODO : comprobar checkpoints
    }

    public override void Draw(Matrix view, Matrix projection)
    {
        Model.Draw(view, projection);
    }

    public override bool Intersects(Character sphere)
    {
        return Box.Intersects(sphere.GetBoundingSphere());
    }

    public void Respawn(Character sphere)
    {
        sphere.Respawn(RespawnPosition, RespawnYaw);
    }

    protected override GeometricPrimitive CreateModel(GraphicsDevice graphicsDevice, ContentManager content, Vector3 coordinates, Vector3 scale, Matrix rotation)
    {
        return new CubePrimitive(graphicsDevice, content, Color.Red, DefaultSize, coordinates, scale, rotation);
    }
}
