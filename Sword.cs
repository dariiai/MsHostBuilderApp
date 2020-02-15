namespace MsHostBuilderApp
{
    public class Sword : IWeapon
    {
        public void Strike(Enemy enemy)
        {
            System.Console.WriteLine($"Striking Enemy {enemy.ID} {enemy.Name}");
        }
    }
}
