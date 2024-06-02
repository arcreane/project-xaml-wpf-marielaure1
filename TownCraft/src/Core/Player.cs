using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Core
{
    public class Player
    {
        public Player()
        {
        }

        public string Name { get; set; }

        public int Level { get; set; }

        public int ChallengesCompleted { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetLevel(int level)
        {
            Level = level;
        }

        public int GetLevel()
        {
            return Level;
        }

        public void SetChallengesCompleted(int challengesCompleted)
        {
            // TODO implement here
        }

        public int GetChallengesCompleted()
        {
            // TODO implement here
            return 0;
        }

    }
}
