using System;
using UnityEngine;


namespace AssemblyCSharp
{
	public class WorldObject
	{
		bool _isAnimated;
		public int x,y;
		int numFrames;
		int id;
		int dir;
		int currentFrame;
		float gameTime=0;
		public bool Renderable;
		
		public bool CanWalkThrough{ get; private set; }
		
		public WorldObject(bool renderable,int id,int x,int y):this(id,x,y,false,1)
		{
			this.Renderable = renderable;
		}
		public WorldObject (int id,int x,int y):this(id,x,y,false,1)
		{
			this.Renderable = true;
		}
		public WorldObject (int id,int x,int y, bool isAnimated, int numFrames)
		{
			if (numFrames > 1)
				this.Renderable = true;
			this.id = id;
			this.x = x;
			this.y = y;
			this._isAnimated = isAnimated;
			this.numFrames = numFrames;
			dir = 1;
			currentFrame = id;
			
			switch (id) {
			case 293: // Venstre pipe
				CanWalkThrough = false;
				
				break;
			}
			
		}
		public void Update()
		{
			if (numFrames == 1) // Ikke noe vits å prøve på animering med kun 1 frame her.
				
				return; 
			gameTime += Time.deltaTime;
			if (gameTime < 0.1)
				return;
			
			gameTime = 0;
			currentFrame += dir;
			if (currentFrame - id == numFrames) {
				dir = -1;
				currentFrame--;
			} else if (currentFrame < id) 
			{
				dir=1;
				currentFrame=id;
			}
		}
		public int GetTileIdForRender()
		{
			return currentFrame;
		}
	}
}
