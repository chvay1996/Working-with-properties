using System;

namespace Working_with_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(5, 3);
            DrowPlayer drowPlayer = new DrowPlayer();

            drowPlayer.Drow(player.PositionX, player.PositionY);
        }
    }

    class Player
    {
        public byte PositionX { get; private set; }
        public byte PositionY { get; private set; }

        public Player(byte positionX, byte positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }
    }
    
    public class DrowPlayer
    {
        public void Drow(byte positionX, byte positionY, char simvol = '@')
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(simvol);
            Console.ResetColor();
        }
    }
}
/*Задача:
Создать класс игрока, у которого есть поля с его положением в x,y.
Создать класс отрисовщик, с методом который отрисует игрока.

Попрактиковаться в работе со свойствами.*/