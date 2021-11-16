using System;
using System.Collections.Generic;

namespace Users
{
    public class User
    {
        public static List<string> people = new List<string>()
        {
            "Johan",
            "Jasmin",
            "Phillip",
            "Alex"
        };

        public static string AddUser(string name)
        {
            people.Add(name);

            if (people.Contains(name))
            {
                return $"user added {name}";
            }

            return null;
        }

        public static string DeleteUser(string name)
        {
            people.Remove(name);

            if (!people.Contains(name))
            {
                return $"user deleted {name}";
            }

            return null;
        }

        public static string UpdateUser(string currentName, string newName)
        {
            if (!people.Contains(currentName))
            {
                return null;
            }

            people.Remove(currentName);

            people.Add(newName);

            if (people.Contains(newName))
            {
                return $"user name changed to {newName}";
            }

            return null;
        }
    }
}
