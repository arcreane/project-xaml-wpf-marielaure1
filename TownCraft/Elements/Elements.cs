using TownCraft.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Elements
{
    /// <summary>
    /// GraphicalElement
    /// </summary>
    public class Elements : TownCraft.Core.Cell
    {

        public Elements()
        {
        }

        public string Type { get; set; }

        public string Position { get; set; }

        public string Texture { get; set; }

        public string GetType()
        {
            // TODO implement here
            return "";
        }

        public string GetPosition()
        {
            // TODO implement here
            return "";
        }

        public void SetType(string type)
        {
            // TODO implement here
        }

        public void SetPosition(string position)
        {
            // TODO implement here
        }

        public string GetTexture()
        {
            // TODO implement here
            return "";
        }

        public void SetTexture(string texture)
        {
            // TODO implement here
        }

    }
}
