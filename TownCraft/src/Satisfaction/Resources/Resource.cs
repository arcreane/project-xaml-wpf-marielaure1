using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TownCraft.Satisfaction.Resources
{
    /// <summary>
    /// Classe de base pour toutes les ressources
    /// </summary>
    public abstract class Resource : Satisfaction
    {
        /// <summary>
        /// Classe de base pour toutes les ressources
        /// </summary>
        public Resource()
        {
        }

        /// <summary>
        /// Nom de la ressource
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// "Water" ou "Electricity"
        /// </summary>
        public string Type { get; set; }

        public int Quantity { get; set; }

        /// <summary>
        /// Récupérer la quantité disponible de la ressource
        /// </summary>
        public void GetAvailableQuantity()
        {
            // TODO implement here
        }

        /// <summary>
        /// Consommer une quantité de la ressource
        /// </summary>
        public void Consume()
        {
            // TODO implement here
        }

        /// <summary>
        /// Générer une quantité de la ressource
        /// </summary>
        public void Generate()
        {
            // TODO implement here
        }
    }
}
