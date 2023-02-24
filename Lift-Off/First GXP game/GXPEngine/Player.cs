using System;
namespace GXPEngine
{
    public class Player : AnimationSprite
    {

		public int hearts = 6;

		float speed = 7;
		float horizontal = 0;
		float vertical = 0;

		public bool joystickActive;
		public bool cantEngage;
		bool moving;

		public Sprite aim;

		public Player() : base("Morgan-Sheet.png", 3, 3)
		{
			SettingsForPlayer();
            SettingUpTheAim();
        }

        void SettingUpTheAim()
        {
            aim = new Sprite("WhereCheckpoint.png");
			aim.visible = false;
			aim.SetOrigin(aim.width / 2, aim.height / 2);
            aim.collider.isTrigger = true;
            aim.SetXY(-6, 0);
            aim.scale = 0.3f;
            AddChild(aim);
        }

        void SettingsForPlayer() {

			scale = 1.3f;
			SetOrigin(width / 2, height / 2);
            SetXY(game.width / 2, game.height / 2);
		}

		private void HandleMovement()
		{


			if (Input.GetKey(Key.W))
			{
				MoveUntilCollision(0, -speed);
			}

			if (Input.GetKey(Key.S))
			{
				MoveUntilCollision(0, speed);
			}

			if (Input.GetKey(Key.A))
			{
				MoveUntilCollision(-speed, 0);
			}

			if (Input.GetKey(Key.D))
			{
				MoveUntilCollision(speed, 0);
			}

		}

        void HandleAim()
        {
			if (vertical == 0 && horizontal == 0) {
				//aim.visible = false;
				joystickActive = false;
			}

            if (Input.GetKey(Key.UP)) { vertical = 1; joystickActive = true; aim.visible = true; }
            if (Input.GetKey(Key.DOWN)) { vertical = -1; joystickActive = true; aim.visible = true; }
            if (Input.GetKey(Key.LEFT)) { horizontal = -1; joystickActive = true; aim.visible = true; }
            if (Input.GetKey(Key.RIGHT)) { horizontal = 1; joystickActive = true; aim.visible = true; }

			if (Input.GetKeyUp(Key.UP)) { vertical = 0; aim.visible = false; }
			if (Input.GetKeyUp(Key.DOWN)) { vertical = 0; aim.visible = false; }
			if (Input.GetKeyUp(Key.LEFT)) { horizontal = 0; aim.visible = false; }
			if (Input.GetKeyUp(Key.RIGHT)) { horizontal = 0; aim.visible = false; }

			if (vertical < 0) { SetFrame(0); }
			if (vertical > 0) { SetFrame(3); }
			if (horizontal < 0 && vertical == 0) { SetFrame(2); }
			if (horizontal > 0 && vertical == 0) { SetFrame(1); }

			aim.rotation = Mathf.Atan2(-vertical , horizontal ) * 180 / Mathf.PI - 90f;

        }

		//void OnCollision(GameObject other)
		//{

		//}


		protected void Update()
		{
			moving = false;
			hearts = (int)Mathf.Clamp(hearts, 0, 6);

			if (!cantEngage)
			{
				HandleMovement();
				HandleAim();
			}
		}

	}
}
