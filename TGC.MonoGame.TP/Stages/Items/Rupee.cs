using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using TGC.MonoGame.TP.MainCharacter;
using TGC.MonoGame.TP.Geometries;

namespace TGC.MonoGame.TP.Stages.Items
{
    internal class Rupee : Pickup
    {
        public Rupee(GraphicsDevice graphicsDevice, ContentManager content, Vector3 center) : base(graphicsDevice, content, center) { }

        protected override GeometricPrimitive CreateModel(GraphicsDevice graphicsDevice, ContentManager content, Vector3 center)
        {
            return new RupeePrimitive(graphicsDevice, contentMgr, DefaultSize, Color.Green, Position);
        }

        protected override void ModifyCharacterStats(Character sphere)
        {
            throw new NotImplementedException(); // TODO: aumentar puntaje un poco
        }

    }
}

