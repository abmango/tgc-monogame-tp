using Microsoft.Xna.Framework;
using TGC.MonoGame.TP.MainCharacter;
using TGC.MonoGame.TP.Geometries;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using BepuPhysics.Constraints;
using static System.Formats.Asn1.AsnWriter;
using TGC.MonoGame.TP.StageComponents;

abstract class Pickup : StageComponent
{

    protected float Yaw;

    public Pickup(GraphicsDevice graphicsDevice, ContentManager content, Vector3 center)
    {
        graphics = graphicsDevice;
        contentMgr = content;
        Position = center;
        Vector3 min = center - Vector3.One;
        Vector3 max = center + Vector3.One;
        Box = new BoundingBox(min, max);
        Yaw = 0;

        Model = CreateModel(graphicsDevice, content, center);
    }

    public override bool Intersects(Character sphere)
    {
        return Box.Intersects(sphere.GetBoundingSphere());
    }

    public override void Update(GameTime gameTime)
    {
        float elapsedTime = (float) gameTime.ElapsedGameTime.TotalSeconds;
        Yaw += elapsedTime * MathHelper.Pi;

        Model.World = Matrix.CreateFromYawPitchRoll(Yaw, 0, 0) * Matrix.CreateTranslation(Position);
    }

    public override void Draw(Matrix view, Matrix projection)
    {
        Model.Draw(view, projection);
    }

    protected override GeometricPrimitive CreateModel(GraphicsDevice graphicsDevice, ContentManager content, Vector3 coordinates, Vector3 scale, Matrix rotation)
    {
        // todos los items van a tener un tamaño estándar y van a rotar a la par
        return CreateModel(graphicsDevice, contentMgr, coordinates);
    }
    protected abstract GeometricPrimitive CreateModel(GraphicsDevice graphicsDevice, ContentManager content, Vector3 coordinates);

    protected abstract void ModifyCharacterStats(Character sphere);


}