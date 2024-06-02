using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGC.MonoGame.TP.Geometries;
using TGC.MonoGame.TP.MainCharacter;
using BepuPhysics.Constraints;
using TGC.MonoGame.TP.StageComponents;

internal class MobileObstacle : StageComponent
{
    protected Vector3 Scale;
    protected Vector3 Rotation;
    protected Vector3 Movement;

    public MobileObstacle(GraphicsDevice graphicsDevice, ContentManager content, Vector3 coordinates, Vector3 scale, Vector3 rotation, Vector3 movement)
    {
        graphics = graphicsDevice;
        contentMgr = content;
        Position = coordinates;
        Scale = scale;
        Rotation = rotation;
        Movement = movement;

        // TODO : BoundingBox
        //Vector3 min = center - Vector3.One;
        //Vector3 max = center + Vector3.One;
        //Box = new BoundingBox(min, max);
        
        // TODO : rotation
         Model = CreateModel(graphicsDevice, content, coordinates, scale, Matrix.CreateFromYawPitchRoll(0,0,0));
    }

    public override bool Intersects(Character sphere)
    {
        return Box.Intersects(sphere.GetBoundingSphere());
    }
    public override void Update(GameTime gameTime)
    {
        // TODO : Movimiento
        throw new NotImplementedException();
    }

    public override void Draw(Matrix view, Matrix projection)
    {
        Model.Draw(view, projection);
    }

    protected GeometricPrimitive CreateModel(GraphicsDevice graphicsDevice, ContentManager content, Vector3 coordinates, Vector3 scale, Matrix rotation)
    {
        return new CubePrimitive(graphicsDevice, content, Color.Gray, DefaultSize, coordinates, scale, rotation);
    }

}

