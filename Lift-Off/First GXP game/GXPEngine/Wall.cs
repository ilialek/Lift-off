using System;
namespace GXPEngine
{
    public class Wall : Sprite
    {

        Level level;

        public Wall(Level levelScript) : base("Asteroid.png")
        {
            SetOrigin(this.width / 2, this.height / 2);
            level = levelScript;
            scale = 1.5f;
		}

        void Update() {
            if (level.scriptDisabled == true) {
                LateDestroy();
            }
        }
	}
}
