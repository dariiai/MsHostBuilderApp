﻿using System.Threading.Tasks;

namespace MsHostBuilderApp
{
    public class Game
    {
        public Hero Hero { get; }
        public IWeapon Weapon { get; }
        public Enemy Enemy { get; }

        public Game(Hero hero, IWeapon weapon, Enemy enemy)
        {
            Hero = hero;
            Weapon = weapon;
            Enemy = enemy;
        }

        public async Task Start()
        {
            await Task.CompletedTask;

            Weapon.Strike(Enemy);
        }

    }
}
