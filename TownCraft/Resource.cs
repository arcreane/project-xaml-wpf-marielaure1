
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Classe de base pour toutes les ressources
/// </summary>
public abstract class Resource : Satisfaction {

    /// <summary>
    /// Classe de base pour toutes les ressources
    /// </summary>
    public Resource() {
    }

    /// <summary>
    /// Nom de la ressource
    /// </summary>
    public string name;

    /// <summary>
    /// "Water" ou "Electricity"
    /// </summary>
    public string type;

    public int quantity;

    /// <summary>
    /// Récupérer la quantité d'une ressource
    /// </summary>
    public void getAvailableQuantity() {
        // TODO implement here
    }

    /// <summary>
    /// Retirer de la quantité à la ressource
    /// </summary>
    public void consume() {
        // TODO implement here
    }

    /// <summary>
    /// Ajouter de la quantité à la ressource
    /// </summary>
    public void generate() {
        // TODO implement here
    }

}