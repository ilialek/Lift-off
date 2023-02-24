using System;
namespace GXPEngine
{
    public class Menu : GameObject
    {

        //Button _button;
        Sprite background;
        Sprite transition;
        bool startTransition;
        bool _hasStarted;

        public Menu() : base()
        {
            _hasStarted = false;

            background = new Sprite("Arcade_background.png");
            background.collider.isTrigger = true;
            AddChild(background);

            transition = new Sprite("transition_screen.png");
            transition.collider.isTrigger = true;
            transition.scale = 2;
            transition.alpha = 0;
            AddChild(transition);
            //_button = new Button("Play_button.png");
            //AddChild(_button);
            //_button.SetXY(game.width / 2, game.height / 2 + 80);
        }

        void Update() {
            if (Input.GetKeyDown(Key.W))
            {
                //new Sound("Pickup_sound.mp3", false, false).Play();
                startTransition = true;
            }

            if (startTransition)
            {
                transition.alpha += 0.05f;

                if (transition.alpha >= 1)
                {
                    background.visible = false;
                    startGame();
                    startTransition = false;
                    transition.alpha = 0;
                    LateDestroy();
                }
            }
        }

        void startGame() {
            if (!_hasStarted)
            {
                Level level = new Level();
                parent.AddChild(level);
                _hasStarted = true;
            }
        }

    }
}
