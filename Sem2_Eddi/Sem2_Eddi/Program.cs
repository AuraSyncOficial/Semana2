using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Eddi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IWeapon> inventory = new List<IWeapon>();

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.- add sword");
                Console.WriteLine("2.- add bow");
                Console.WriteLine("3.- add pistol");
                Console.WriteLine("4.- add arrow");
                Console.WriteLine("5.- add bullet");
                Console.WriteLine("6.- view inventory");
                Console.WriteLine("7.- remove weapon from inventory");
                Console.WriteLine("8.- exit");
                Console.Write("Select an option: ");

                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            addsword(inventory);
                            break;
                        case 2:
                            addbow(inventory);
                            break;
                        case 3:
                            addPistol(inventory);
                            break;
                        case 4:
                            addarrow(inventory);
                            break;
                        case 5:
                            addbullet(inventory);
                            break;
                        case 6:
                            viewinventory(inventory);
                            break;
                        case 7:
                            deletearm(inventory);
                            break;
                        case 8:
                            return;
                        default:
                            Console.WriteLine("Invalid option. Try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option. Try again.");
                }
            }
        }

        static void addsword(List<IWeapon> inventory)
        {
            Console.Write("sword name: ");
            string name = Console.ReadLine();

            Console.Write("sword damage: ");
            int damage = int.Parse(Console.ReadLine());

            Console.Write("sword attack speed: ");
            double Vatack = double.Parse(Console.ReadLine());

            Console.Write("sword price: ");
            double price = double.Parse(Console.ReadLine());

            Melee sword = new Melee(name, damage, Vatack, price);
            inventory.Add(sword);

            Console.WriteLine($"sword '{name}' added to inventory.");
        }

        static void addbow(List<IWeapon> inventory)
        {
            Console.Write("bow name: ");
            string name = Console.ReadLine();

            Console.Write("bow damage: ");
            int damage = int.Parse(Console.ReadLine());

            Console.Write("bow attack speed: ");
            double Vatack = double.Parse(Console.ReadLine());

            Console.Write("bow price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("arrow name: ");
            string nameProjectile = Console.ReadLine();

            Console.Write("arrow damage: ");
            int damageProjectile = int.Parse(Console.ReadLine());

            IProjectile arrow = new Projectile(damageProjectile);
            WeaponDistance bow = new WeaponDistance(name, damage, Vatack, price, arrow);
            inventory.Add(bow);

            Console.WriteLine($"bow '{name}' with arrow '{nameProjectile}' in inventory.");
        }

        static void addPistol(List<IWeapon> inventory)
        {
            Console.Write("pistol name: ");
            string name = Console.ReadLine();

            Console.Write("pistol damage: ");
            int damage = int.Parse(Console.ReadLine());

            Console.Write("pistol attack speed: ");
            double Vatack = double.Parse(Console.ReadLine());

            Console.Write("pistol price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("bullet name: ");
            string nameProjectile = Console.ReadLine();

            Console.Write("bullet damage: ");
            int damageProjectile = int.Parse(Console.ReadLine());

            IProjectile bullet = new Projectile(damageProjectile);
            WeaponDistance pistola = new WeaponDistance(name, damage, Vatack, price, bullet);
            inventory.Add(pistola);

            Console.WriteLine($"Pistol '{name}' with bullet '{nameProjectile}' in inventory.");
        }

        static void addarrow(List<IWeapon> inventory)
        {
            Console.Write("arrow name: ");
            string name = Console.ReadLine();

            Console.Write("arrow damage: ");
            int damage = int.Parse(Console.ReadLine());

            Console.Write("arrow attack speed: ");
            double Vatack = double.Parse(Console.ReadLine());

            Console.Write("arrow price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("name of the bow that shoots the arrow: ");
            string nameWeapon = Console.ReadLine();

            WeaponDistance arrow = new WeaponDistance(nameWeapon, damage, Vatack, price, new Projectile(0));
            inventory.Add(arrow);

            Console.WriteLine($"arrow '{name}' for the bow '{nameWeapon}' in inventory.");
        }

        static void addbullet(List<IWeapon> inventory)
        {
            Console.Write("bullet name: ");
            string name = Console.ReadLine();

            Console.Write("bullet damage: ");
            int damage = int.Parse(Console.ReadLine());

            Console.Write("bullet attack speed: ");
            double Vatack = double.Parse(Console.ReadLine());

            Console.Write("bullet price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("name of the gun that fires the bullet: ");
            string nameWeapon = Console.ReadLine();

            WeaponDistance bullet = new WeaponDistance(nameWeapon, damage, Vatack, price, new Projectile(0));
            inventory.Add(bullet);

            Console.WriteLine($"bullet '{name}' for the pistol '{nameWeapon}' in inventory.");
        }

        static void viewinventory(List<IWeapon> inventory)
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
            }
            else
            {
                Console.WriteLine("inventory:");

                for (int i = 0; i < inventory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {inventory[i].Name} (DPS: {inventory[i].CalculateDPS()}, price: {inventory[i].Price})");
                }
            }
        }
        static void deletearm(List<IWeapon> inventory)
        {
            viewinventory(inventory);

            if (inventory.Count == 0)
            {
                Console.WriteLine("There are no weapons to eliminate.");
                return;
            }

            Console.Write("Select the weapon number you want to delete: ");

            if (int.TryParse(Console.ReadLine(), out int seleccion) && seleccion >= 1 && seleccion <= inventory.Count)
            {
                string nameWeaponDelete = inventory[seleccion - 1].Name;
                inventory.RemoveAt(seleccion - 1);
                Console.WriteLine($"Has been removed '{nameWeaponDelete}' from inventory.");
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
    }
}