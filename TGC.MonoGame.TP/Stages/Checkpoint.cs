using Microsoft.Xna.Framework;
using TGC.MonoGame.TP.MainCharacter;

internal class Checkpoint
{
    BoundingBox Box;
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

    public bool Intersec(Character sphere)
    {
        return Box.Intersects(sphere.GetBoundingSphere());
    }

    public void Respawn(Character sphere)
    {
        sphere.Respawn(RespawnPosition, RespawnYaw);
    }

}
