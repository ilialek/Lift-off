using System;
namespace GXPEngine
{
    public class Button : Sprite
    { 
        public Button(string fileName) : base(fileName)
        {
            SetOrigin(width / 2, height / 2);
            collider.isTrigger = true;
        }
    }
}
