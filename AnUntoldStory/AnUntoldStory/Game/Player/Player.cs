using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AnUntoldStory
{
	class Player
    {
		private Texture2D PlayerTexture;
		private Vector2 Position;
		private float MoveSpeed;

		public void Initialize(Texture2D texture, Vector2 position)
		{
			PlayerTexture = texture;
			Position = position;
			MoveSpeed = 6.0f;
		}

		public void Update()
		{

		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
		}

		
		//Setters
		public void setMoveSpeed(float moveSpeed)
		{
			MoveSpeed = moveSpeed;
		}

		public void setPosition(Vector2 position)
		{
			Position = position;
		}

		public void setPositionX(float positionX)
		{
			Position.X = positionX;
		}

		public void setPositionY(float positionY)
		{
			Position.Y = positionY;
		}

		//Getters
		public float getMoveSpeed()
		{
			return MoveSpeed;
		}

		public Vector2 getPosition()
		{
			return Position;
		}

		public int getWidth()
		{
			return PlayerTexture.Width;
		}

		public int getHeight()
		{
			return PlayerTexture.Height;
		}
	}
}
