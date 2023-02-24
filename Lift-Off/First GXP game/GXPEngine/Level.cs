using System;
using System.Drawing;
using System.Collections.Generic;
namespace GXPEngine
{
    public class Level : GameObject
    {

        public int destroyedEnemies = 0;

        public int currentLevel = 1;

        public bool scriptDisabled = false;

        public int amountToSpawnPerLevel = 2;

        int[] map1 = {
        1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,0,0,0,0,0,1,
        1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1

        };
        int[] map2 = {
        1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1
        };
        int[] map3 = {
        1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1
        };

        public int[] currentMap = new int[1024];

        int amountOfBlackholes = 0;
        int amountOfBlackholesPerLevel = 4;

        AnimationSprite[] hearts = new AnimationSprite[6];

        Sprite transition;
        bool startTransition;

        Sprite deathScreen;
        //bool startTransition;

        Player player;

        Merchant merchant;

        public EasyDraw canvas;
        EasyDraw canvas2;

        Sprite background;
        Sprite aim;

        List<Wall> walls = new List<Wall>();
        List<Bullet> bullets = new List<Bullet>();
        List<Enemy> enemies = new List<Enemy>();
        List<Blackhole> blackholes = new List<Blackhole>();

        Random rnd = new Random();

        float timeToShoot = 0;
        float shootRate = 800;

        float timeToBlackHole = 0;
        float blackholeRate = 3000;

        public Level()
        {
			Settings();
		}

        void DrawTheLevel() {

            if (currentLevel == 1) {
                for (int i = 0; i < map1.Length; i++) {
                    currentMap[i] = map1[i];
                }
            }

            if (currentLevel == 2)
            {
                for (int i = 0; i < map2.Length; i++)
                {
                    currentMap[i] = map2[i];
                }
            }

            if (currentLevel == 3)
            {
                for (int i = 0; i < map3.Length; i++)
                {
                    currentMap[i] = map3[i];
                }
            }

            for (int i = 0; i < 32; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    if (currentMap[32 * i + j] == 1)
                    {
                        walls.Add(new Wall(this));
                        walls[walls.Count - 1].SetXY((game.width / 2 - 372) + walls[walls.Count - 1].width / 2 + j * 24, (game.height / 2 - 372) + walls[walls.Count - 1].height / 2 + i * 24);
                        canvas.AddChild(walls[walls.Count - 1]);
                    }
                }
            }
        } 

		void Settings()
		{

			canvas = new EasyDraw(1600, 900, false);
			AddChild(canvas);

            background = new Sprite("Background_1.png");
            background.collider.isTrigger = true;
            canvas.AddChild(background);

            DrawTheLevel();

            player = new Player();
			canvas.AddChild(player);

            for (int i = 0; i < 6; i++)
            {
                hearts[i] = new AnimationSprite("Hearts.png", 6, 1);
                hearts[i].SetFrame(i);
                hearts[i].scale = 0.5f;
                hearts[i].SetXY(i * (hearts[i].width) + 30, 30);
                canvas.AddChild(hearts[i]);
            }

            transition = new Sprite("transition_screen.png");
            transition.collider.isTrigger = true;
            transition.scale = 2;
            transition.alpha = 0;
            AddChild(transition);

            deathScreen = new Sprite("you_died_screen.png");
            deathScreen.collider.isTrigger = true;
            deathScreen.scale = 2;
            deathScreen.alpha = 0;
            AddChild(deathScreen);

            merchant = new Merchant(this);
        }

        //Update
        void Update()
        {
            if (!scriptDisabled && player.hearts != 0)
            {
                SpawnBlackholes();
                EnemyPathSeting();
                ShootingBullets();
                CheckIfCompleted();
            }

            CheckIfDead();

            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].willBeDestroyed == true)
                {
                    enemies.RemoveAt(i);
                }
            }

            for (int i = 0; i < blackholes.Count; i++)
            {
                if (blackholes[i].willBeDestroyed == true)
                {
                    blackholes.RemoveAt(i);
                }
            }

            if (player.hearts < 6 && player.hearts >= -1)
            {
                for (int i = 5; i > player.hearts; i--)
                {
                    hearts[i].visible = false;
                }
            }

        }

        void CheckIfDead() {

            if (player.hearts == 0) {

                player.cantEngage = true;

                deathScreen.alpha += 0.005f;

                if (deathScreen.alpha >= 1)
                {
                    scriptDisabled = true;
                    //destroyedEnemies = 0;
                    //ResetTheLevel();
                    Menu menu = new Menu();
                    parent.AddChild(menu);
                    deathScreen.alpha = 0;
                    LateDestroy();
                }
            }
        }

        void CheckIfCompleted() {

            if (currentLevel == 1 && destroyedEnemies == amountToSpawnPerLevel * amountOfBlackholesPerLevel)
            {
                transition.alpha += 0.05f;

                if (transition.alpha >= 1)
                {
                    scriptDisabled = true;
                    destroyedEnemies = 0;
                    ResetTheLevel();
                    currentLevel++;
                    AddChild(merchant);
                    transition.alpha = 0;
                }

            }

            if (currentLevel == 2 && destroyedEnemies == amountToSpawnPerLevel * amountOfBlackholesPerLevel)
            {
                //merchant = new Merchant(this);
                //AddChild(merchant);
                scriptDisabled = true;
                destroyedEnemies = 0;
                ResetTheLevel();
                currentLevel++;
            }
        }

        public void SettingUpTheLevels() {

            if (currentLevel == 2)
            {
                amountToSpawnPerLevel = 2;
                amountOfBlackholesPerLevel = 4;
                scriptDisabled = false;
                DrawTheLevel();
                player.SetXY(game.width / 2, game.height / 2);
            }
            if (currentLevel == 3)
            {
                amountToSpawnPerLevel = 2;
                amountOfBlackholesPerLevel = 4;
                scriptDisabled = false;
                DrawTheLevel();
                player.SetXY(game.width / 2, game.height / 2);
            }
        }

        void ResetTheLevel() {
            amountOfBlackholes = 0;
            timeToShoot = 0;
            timeToBlackHole = 0;
            destroyedEnemies = 0;

            for (int i = 0; i < enemies.Count; i++)
            {
                enemies.RemoveAt(i);
            }

            for (int i = 0; i < blackholes.Count; i++)
            {
                blackholes.RemoveAt(i);
            }

            for (int i = 0; i < bullets.Count; i++)
            {
                bullets.RemoveAt(i);
            }

            for (int i = 0; i < walls.Count; i++)
            {
                walls.RemoveAt(i);

            }

        }

        public void SpawnEnemies(int x, int y)
        {
            if (currentLevel == 1)
            {
                enemies.Add(new Enemy("marshmallow_Sprite_sheet.png", 4, 5, this, 1));
                enemies[enemies.Count - 1].SetXY(x, y);
                canvas.AddChild(enemies[enemies.Count - 1]);
            }

            if (currentLevel == 2)
            {
                //bool typeOfEnemyForSecondLevel = false;
                //typeOfEnemyForSecondLevel = !typeOfEnemyForSecondLevel;
                //if (typeOfEnemyForSecondLevel)
                //{
                //    enemies.Add(new Enemy("marshmallow_Sprite_sheet.png", 4, 5, this, 1));
                //    enemies[enemies.Count - 1].SetXY(x, y);
                //    canvas.AddChild(enemies[enemies.Count - 1]);
                //}
                //else {
                    enemies.Add(new Enemy("mothman_Sprite_sheet.png", 6, 5, this, 2));
                    enemies[enemies.Count - 1].SetXY(x, y);
                    canvas.AddChild(enemies[enemies.Count - 1]);
                //}
             
            }
        }

        void SpawnBlackholes() {

            Console.WriteLine(blackholes.Count);

            if (Time.time - timeToBlackHole >= blackholeRate && amountOfBlackholes != amountOfBlackholesPerLevel)
            {
                int rndX = rnd.Next(2, 25);
                int rndY = rnd.Next(2, 25);
                int amountOfOnes = 0;

                for (int j = rndY; j < 7 + rndY; j++) {
                    for (int i = rndX; i < 7 + rndX; i++)
                    {
                        if (currentMap[32 * j + i] == 1) {
                            amountOfOnes++;
                        }
                    }
                }

                if (amountOfOnes == 0)
                {
                    blackholes.Add(new Blackhole(this));
                    blackholes[blackholes.Count - 1].SetXY((game.width / 2 - 372) + rndX * 24, (game.height / 2 - 372) + rndY * 24);
                    canvas.AddChild(blackholes[blackholes.Count - 1]);
                    amountOfBlackholes++;
                }
                else {
                    SpawnBlackholes();
                }

                timeToBlackHole = Time.time;
            }
        }

        void EnemyPathSeting() {
            for (int i = 0; i < enemies.Count; i++) {
                enemies[i].targetX = (int)player.x;
                enemies[i].targetY = (int)player.y;
            }
        }

        void ShootingBullets() {

            if (player.joystickActive)
            {
                if (Time.time - timeToShoot >= shootRate)
                {

                    bullets.Add(new Bullet());
                    bullets[bullets.Count - 1].SetXY(player.x, player.y);
                    bullets[bullets.Count - 1].rotation = player.aim.rotation;
                    canvas.AddChild(bullets[bullets.Count - 1]);

                    //if (enemies.Count != 0)
                    //{

                    //float distance = Mathf.Sqrt((Mathf.Pow(enemies[0].x - player.x, 2) + Mathf.Pow(enemies[0].y - player.y, 2)));
                    //int closestEnemy = 0;

                    //for (int i = 0; i < enemies.Count; i++)
                    //{
                    //    if (Mathf.Sqrt((Mathf.Pow(enemies[i].x - player.x, 2) + Mathf.Pow(enemies[i].y - player.y, 2))) < distance)
                    //    {
                    //        distance = Mathf.Sqrt((Mathf.Pow(enemies[i].x - player.x, 2) + Mathf.Pow(enemies[i].y - player.y, 2)));
                    //        closestEnemy = i;
                    //    }
                    //}


                    //}

                    timeToShoot = Time.time;
                }
            }
        }


	}
}

