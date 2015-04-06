//Frank Gu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Phosphaze.Core;

namespace Phosphaze.Core
{
    class Ship
    {
        private Vector2 pos;
        private float width, height;
        private Texture2D texture;
        public Ship(float x, float y, float w, float h,Texture2D t)
        {
            pos = new Vector2(x, y);
            width = w;
            height = h;
            texture = t;
        }

        public void CenterOnPos(float x, float y)
        {
            pos.X = x - width / 2;
            pos.Y = y - height / 2;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(texture, pos, Color.White);
            spriteBatch.End();
        }
    }
}
