using System;
namespace GXPEngine
{
    public class Merchant : GameObject
    {

        public Button _button;
        Level level;
        EasyDraw canvas;
        public bool _hasStarted = false;

        public Merchant(Level levelScript)
        {
            canvas = new EasyDraw(1600, 900, false);
            AddChild(canvas);

            canvas.Clear(System.Drawing.Color.Black);

            level = levelScript;
            _button = new Button("square.png");
            AddChild(_button);
            _button.SetXY(game.width - 200, game.height - 200);
        }

        void Update() {

            canvas.Clear(System.Drawing.Color.Black);

            if (Input.GetMouseButtonDown(0))
            {
                if (_button.HitTestPoint(Input.mouseX, Input.mouseY) && !_hasStarted)
                {
                    level.SettingUpTheLevels();
                    LateDestroy();
                    //hideMenu();
                    //_hasStarted = true;
                }
            }

        }

        void hideMenu()
        {
            _button.visible = false;
            visible = false;
        }

    }
}
