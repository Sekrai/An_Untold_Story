using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


//Add one of these to whatever you want to collide, don't forget to init the box

namespace AnUntoldStory
{
    class BoxCollision
    {
        private Rectangle myRectangle;

        public void Initialize(Vector2 aPosition, int aWidth, int aHeight)
        {
            myRectangle = new Rectangle((int)aPosition.X, (int)aPosition.Y, aWidth, aHeight);
        }

        public bool CheckBoxCollision(Rectangle aRectangle)
        {
            if (myRectangle.Intersects(aRectangle) == true)
            {
                return (true);
            }
            return (false);
        }

        public Rectangle GetRectangle()
        {
            return (myRectangle);
        }

        public void SetRectangle(Rectangle aRectangle)
        {
            myRectangle = aRectangle;
        }
    }
}
