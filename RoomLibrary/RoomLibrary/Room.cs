using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLength;
        double roomWidth;

        public double RoomLength
        {
            get { return roomLength; }
            set { roomLength = value; }
        }

        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }

        /// <summary>
        /// Вычисляет периметр комнаты
        /// </summary>
        /// <returns>Значение периметра</returns>
        public double RoomPerimeter()
        {
            return 2 * (roomLength + roomWidth);
        }

        /// <summary>
        /// Вычисляет площадь комнаты
        /// </summary>
        /// <returns>Значение площади</returns>
        public double RoomArea()
        {
            return roomLength * roomWidth;
        }

        /// <summary>
        /// Вычисляет число кв. м.
        /// </summary>
        /// <param name="np">Число человек</param>
        /// <returns>Число кв. м.</returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }

        /// <summary>
        /// Информация о комнате
        /// </summary>
        /// <returns>Возвращает строку</returns>
        public virtual string Info()
        {
            return $"Жилая комната площадью {RoomArea()} кв. м.";
        }
    }

    /// <summary>
    /// Класс "жилая комната"
    /// </summary>
    public class LivingRoom : Room
    {
        int numWin;
        
        public int NumWin
        {
            get { return numWin; }
            set { numWin = value; }
        }

        /// <summary>
        /// Информация о комнате
        /// </summary>
        /// <returns>Возвращает строку</returns>
        public override string Info()
        {
            return $"Жилая комната площадью {RoomArea()} кв. м., с {numWin} окнами.";
        }
    }

    public class Office : Room
    {
        int numSockets;

        public int NumSockets
        {
            get { return numSockets; }
            set { numSockets = value; }
        }

        /// <summary>
        /// Максимально возможное число рабочих мест
        /// </summary>
        /// <returns>Число мест</returns>
        public int NumWorkplaces()
        {
            int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
            return Math.Min(numSockets, num);
        }

        /// <summary>
        /// Информация о офиск
        /// </summary>
        /// <returns>Возвращает строку</returns>
        public override string Info()
        {
            return $"Офис на {NumWorkplaces()} рабочих мест";
        }
    }
}
