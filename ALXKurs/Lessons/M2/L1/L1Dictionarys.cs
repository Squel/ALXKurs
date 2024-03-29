﻿using ALXKurs.Lessons.M2.L1.ClassesAndEnums;

namespace ALXKurs.Lessons.M2.L1
{
    public class L1Dictionarys
    {
        public static void Run()
        {
            var fruitDictionary = new Dictionary<int, string>()
            {
                {1, "Banana" },
                {2, "Apple" },
                {3, "Guanabana" },
                {4, "Strawberry" },
                {5, "Melon" },
                {6, "Tomato" },
                {7, "Kiwi" },
                {8, "Peach" },
                {9, "Blueberry" },
                {0, "Pineapple" },
                {11, "Watermelon" },
            };

            Console.WriteLine(fruitDictionary[1]);
            fruitDictionary.Add(34, "Raspberry");
        }

        public static void Run1()
        {
            UserDTO userDTO = new UserDTO
            {
                Name= "ab@costam.pl",
                Role = "Administrator"
            };
            var user = MapDTO(userDTO);
            Console.WriteLine($"User: \n\tname:{user.Name}\n\trole:{user.Role}");
        }

        private static User MapDTO(UserDTO userDTO)
        {
            var user = new User();
            user.Name = userDTO.Name;

            Dictionary<string, UserRoles> mapDictionary = new Dictionary<string, UserRoles>()
            {
                { "administrator", UserRoles.ADMINISTRATOR},
                { "user", UserRoles.USER},
                { "supervisior", UserRoles.SUPERVISOR},
                { "data_contractor", UserRoles.DATA_CONTRACTOR},
            };
            var roleFromDTO = userDTO.Role
                .ToLower()
                .Replace(" ", "");
             user.Role = mapDictionary[roleFromDTO];
            return user;
        }
    }
}
