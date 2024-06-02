using Microsoft.Xna.Framework;
using TGC.MonoGame.TP.MainCharacter;
using TGC.MonoGame.TP.StageComponents;

internal class Checkpoint : StageComponent
{
    Vector3 RespawnPosition;
    float RespawnYaw;

    public Checkpoint(Vector3 center, Vector3 scale, float yaw)
    {
        RespawnPosition = center;
        RespawnYaw = yaw;

        Vector3 min = center - scale;
        Vector3 max = center + scale;
        Box = new BoundingBox(min, max);
    }

    public override void Draw(Matrix view, Matrix projection)
    {
        throw new System.NotImplementedException();
    }

    public override bool Intersects(Character sphere)
    {
        return Box.Intersects(sphere.GetBoundingSphere());
    }

    public void Respawn(Character sphere)
    {
        sphere.Respawn(RespawnPosition, RespawnYaw);
    }

    public override void Update(GameTime gameTime)
    {
        throw new System.NotImplementedException();
    }
}
