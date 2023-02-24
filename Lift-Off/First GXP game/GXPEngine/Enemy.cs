using System;
namespace GXPEngine
{
    public class Enemy : AnimationSprite
    {

        float speed;

        public int targetX;
        public int targetY;

        int mothManHealth;

        int value = 0;

        int type;

        Level level;

        Random rnd = new Random();

        public bool willBeDestroyed = false;

        public Enemy(string fileName,int columns, int rows, Level levelClass, int whichType) : base(fileName, columns, rows)
        {
            level = levelClass;
            SetOrigin(width / 2, height / 2);
            type = whichType;
            collider.isTrigger = true;

            if (type == 1) {
                speed = rnd.Next(11, 14) / 10;
            }

            if (type == 2) {
                SetFrame(0);
                mothManHealth = 2;
                speed = rnd.Next(9, 12) / 10;
                scale = 0.5f;
            }
        }

        void OnCollision(GameObject other)
        {
            if (other is Bullet)
            {
                if (type == 1) {
                    willBeDestroyed = true;
                }

                if (type == 2)
                {
                    if (mothManHealth == 0) {
                        willBeDestroyed = true;
                    }
                    mothManHealth--;
                }


            }
            if (other is Player)
            {
                if (type == 1) {
                    x += x - other.x;
                    y += y - other.y;
                    ((Player)other).hearts--;
                }

                //if (type == 2)
                //{
                //    x += x - other.x;
                //    y += y - other.y;
                //    ((Player)other).hearts--;
                //}

            }
        }

        void AnimationHandler() {

            if (type == 1)
            {
                if (willBeDestroyed)
                {

                    SetCycle(8, 10);

                    if (currentFrame == 17)
                    {
                        level.destroyedEnemies++;
                        LateDestroy();
                    }

                }
                else
                {
                    SetCycle(0, 7);
                }

                Animate(0.15f);
            }

            if (type == 2)
            {
                if (willBeDestroyed)
                {

                    SetCycle(15, 12);

                    if (currentFrame == 26)
                    {
                        level.destroyedEnemies++;
                        LateDestroy();
                    }

                }
                else
                {
                    SetCycle(0, 8);
                }

                Animate(0.15f);
            }


        }

        void Update()
        {

            AnimationHandler();

            float ratio;
            ratio = (targetX - x) / (targetY - y);
            float distance;
            distance = Mathf.Sqrt((Mathf.Pow(targetX - x, 2) + Mathf.Pow(targetY - y, 2)));

            if (type == 1) { value = 0; }
            else if (type == 2) { value = 0; }


            int spy = (int)((y - (game.height / 2 - 372)) / 24), spx = (int)((x - (game.width / 2 - 372)) / 24);
            int spx_add = (int)((x - (game.width / 2 - 372) + 24) / 24), spy_add = (int)((y - (game.height / 2 - 372) + 24 + value) / 24);
            int spx_sub = (int)((x - (game.width / 2 - 372) - 24) / 24), spy_sub = (int)((y - (game.height / 2 - 372) - 24 - value) / 24);

            //if (distance >= 50 && !willBeDestroyed)
            //{
            //    if (x > targetX && level.currentMap[spy * 32 + spx_sub] == 0 )
            //    {
            //        x -= Mathf.Abs(targetX - x) / distance * speed;
            //    }
            //    if (x < targetX && level.currentMap[spy * 32 + spx_add] == 0)
            //    {
            //        x += Mathf.Abs(targetX - x) / distance * speed;
            //    }
            //    if (y > targetY && level.currentMap[spy_sub * 32 + spx] == 0)
            //    {
            //        y -= Mathf.Abs(targetY - y) / distance * speed;
            //    }
            //    if (y < targetY && level.currentMap[spy_add * 32 + spx] == 0)
            //    {
            //        y += Mathf.Abs(targetY - y) / distance * speed;
            //    }
            //}

            if (!willBeDestroyed)
            {
                if (x > targetX && level.currentMap[spy * 32 + spx_sub] == 0)
                {
                    x -= Mathf.Abs(targetX - x) / distance * speed;
                }
                if (x < targetX && level.currentMap[spy * 32 + spx_add] == 0)
                {
                    x += Mathf.Abs(targetX - x) / distance * speed;
                }
                if (y > targetY && level.currentMap[spy_sub * 32 + spx] == 0)
                {
                    y -= Mathf.Abs(targetY - y) / distance * speed;
                }
                if (y < targetY && level.currentMap[spy_add * 32 + spx] == 0)
                {
                    y += Mathf.Abs(targetY - y) / distance * speed;
                }
            }


            if (type == 2)
            {
                if (targetX - x >= 0)
                {
                    Mirror(false, false);
                }
                else
                {
                    Mirror(true, false);
                }
            }

        }
    }
}
