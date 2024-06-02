using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using TGC.MonoGame.TP.MainCharacter;
using TGC.MonoGame.TP.Geometries;

namespace TGC.MonoGame.TP.Stages.Items
{
    internal class Ruby : Pickup
    {
        public Ruby(GraphicsDevice graphicsDevice, ContentManager content, Vector3 center) : base(graphicsDevice, content, center) { }

        protected override GeometricPrimitive CreateModel(GraphicsDevice graphicsDevice, ContentManager content, Vector3 center)
        {
            return new DiamondPrimitive(graphicsDevice, contentMgr, DefaultSize, Color.Red, Position);
        }

        protected override void ModifyCharacterStats(Character sphere)
        {
            throw new NotImplementedException(); // TODO: aumentar puntaje mucho
        }

    }
}