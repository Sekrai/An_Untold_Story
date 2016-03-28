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
		
		public void Initialize(Texture2D texture, Vector2 position)
		{
			PlayerTexture = texture;
			Position = position;
		}

		public void Update()
		{

		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
		}
	}
}
