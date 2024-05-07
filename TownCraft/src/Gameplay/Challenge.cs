using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Gameplay
{
    public class Challenge
    {
        public Challenge()
        {
        }

        public string Description { get; set; }

        public bool IsCompleted { get; set; }

        public int Level { get; set; }
    }
}
