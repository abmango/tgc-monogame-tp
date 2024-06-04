
using System.Collections.Generic;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using TGC.MonoGame.TP.Camera;
using TGC.MonoGame.TP.Geometries;
using TGC.MonoGame.TP.MainCharacter;
using TGC.MonoGame.TP.Stages;

abstract class Stage
{

    protected GraphicsDevice GraphicsDevice;
    protected ContentManager Content;

    protected List<GeometricPrimitive> Track; // circuito y obstáculos fijos 
    protected List<MobileObstacle> Obstacles; // obstáculos móviles
    protected List<GeometricPrimitive> Signs; //FIXME: eventualmente podrían ser algo distinto a GeometricPrimitive
    protected List<Pickup> Pickups; //FIXME: eventualmente podrían ser algo distinto a GeometricPrimitive
    protected List<Checkpoint> Checkpoints; // puntos de respawn

    public Vector3 CharacterInitialPosition;
    public float CharacterInitialYaw;

    public Stage(GraphicsDevice graphicsDevice, ContentManager content, Vector3 characterPosition, float characterInitialYaw)
    {
        GraphicsDevice = graphicsDevice;
        Content = content;

        CharacterInitialPosition = characterPosition;
        CharacterInitialYaw = characterInitialYaw;

        LoadTrack();
        LoadObstacles();
        LoadSigns();
        LoadPickups();
        LoadCheckpoints();

    }

    public void Update(GameTime gameTime)
    {
        foreach (MobileObstacle primitive in Obstacles)
        {
            primitive.Update(gameTime);
        }
        foreach (Pickup pickup in Pickups)
        {
            pickup.Update(gameTime);
        }
        foreach (Checkpoint checkpoint in Checkpoints)
        {
            checkpoint.Update(gameTime);
        }
    }

    public void Draw(Matrix view, Matrix projection)
    {
        foreach (GeometricPrimitive primitive in Track)
        {
            primitive.Draw(view, projection);
        }

        foreach (MobileObstacle primitive in Obstacles)
        {
            primitive.Draw(view, projection);
        }

        foreach (GeometricPrimitive sign in Signs)
        {
            sign.Draw(view, projection);
        }

        foreach (Pickup pickup in Pickups)
        {
            pickup.Draw(view, projection);
        }

        foreach (Checkpoint checkpoint in Checkpoints)
        {
            checkpoint.Draw(view, projection);
        }
    }

    abstract protected void LoadTrack();

    abstract protected void LoadObstacles();

    abstract protected void LoadPickups();

    abstract protected void LoadSigns();

    abstract protected void LoadCheckpoints();


}