using System;
namespace GXPEngine
{
    public class Bullet : Sprite
    {

        float timeStarting;

        float speed = 6;

        public Bullet() : base("square.png")
        {
            SetOrigin(width / 2, height / 2);
            scale = 0.3f;
            SetScaleXY(0.1f, 0.2f);

            collider.isTrigger = true;

            timeStarting = Time.time;
        }

        void OnCollision(GameObject other)
        {
            if (other is Enemy || other is Wall)
            {
                LateDestroy();
            }
        }

        void Update()
        {
            Move(0, speed);

            if (Time.time >= timeStarting + 3000) {
                LateDestroy();
            }
        }
    }
}
