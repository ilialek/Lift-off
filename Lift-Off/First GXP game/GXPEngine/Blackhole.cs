using System;
namespace GXPEngine
{
    public class Blackhole : AnimationSprite
    {

        public bool willBeDestroyed;

        float timeToSpawn = 0;
        float spawnRate = 1000;
        int amountOfEnemies;
        bool setAnimation;
        Level levelScript;

        public Blackhole(Level level) : base("Portal_Sprite_sheet.png", 6, 2)
        {
            scale = 2;
            collider.isTrigger = true;
            levelScript = level;
            currentFrame = 0;

            //might change
            timeToSpawn = Time.time;
        }

        void SpawnEnemies()
        {
            if (Time.time - timeToSpawn >= spawnRate)
            {

                levelScript.SpawnEnemies((int)x + width/2, (int)y + height/2);

                amountOfEnemies++;
                timeToSpawn = Time.time;
            }
        }

        void Update()
        {
            SpawnEnemies();

            if (amountOfEnemies >= levelScript.amountToSpawnPerLevel) {
                willBeDestroyed = true;
                LateDestroy();
            }

            SetCycle(0, 12);

            Animate(0.25f);
        }
    }
}
