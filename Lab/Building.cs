using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Building
    {
        private static int id_counter;
        private int id;
        private double height;
        private int level_count;
        private int entrance_count;
        private int room_count;

        /// <summary>
        /// Генерирует уникальный ID
        /// </summary>
        /// <returns></returns>
        private static int GenerateID()
        {
            return id_counter++;
        }

        public Building()
        {
            id = GenerateID();
            height = 45;
            level_count = 15;
            entrance_count = 10;
            room_count = 600;
        }

        public void CalculateHeightOfLevel(int level)
        {
            double level_height = height/level_count * level;
            Console.WriteLine($"Высота {level} этажа: {level_height} м");
        }

        public void CalculateRoomsInEnterance()
        {
            double room_in_enterance = room_count/entrance_count;
            Console.WriteLine($"В одном подьезде комнат: {room_in_enterance}");
        }

        public void CalculateRoomsInFloor()
        {
            double room_in_floor = (room_count / entrance_count)/level_count;
            Console.WriteLine($"На одном этаже комнат: {room_in_floor}");
        }

        public void Print()
        {
            Console.WriteLine($"Номер дома {id}, высота {height} м, этажей {level_count}, подьездов {entrance_count}, комнат {room_count}");
        }
    }
}
