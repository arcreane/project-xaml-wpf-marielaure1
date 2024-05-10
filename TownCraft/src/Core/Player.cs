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
            // TODO implement here
        }

        public string GetName()
        {
            // TODO implement here
            return "";
        }

        public void SetLevel(int level)
        {
            // TODO implement here
        }

        public int GetLevel()
        {
            // TODO implement here
            return 0;
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
