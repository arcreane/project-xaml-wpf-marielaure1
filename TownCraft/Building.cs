
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Building : Elements {

    public Building() {
    }

    public void name;

    public void category;

    public void area;

    public void constructionCost;

    public void energyConsumption;

    public void waterConsumption;

    public void pollutionGenerate;

    public void level;

    public void Attribute1;

    public void employmentRate;

    public void maintenance;

    public void getName() {
        // TODO implement here
    }

    public void setName() {
        // TODO implement here
    }

    public void getCategory() {
        // TODO implement here
    }

    public void setCategory() {
        // TODO implement here
    }

    public void getConstructionCost() {
        // TODO implement here
    }

    public void setConstructionCost() {
        // TODO implement here
    }

    public void getEnergyConsuption() {
        // TODO implement here
    }

    /// <summary>
    /// Simule la consommation d'énergie du bâtiment
    /// </summary>
    public void setEnergyConsuption() {
        // TODO implement here
    }

    public void getWaterConsumption() {
        // TODO implement here
    }

    /// <summary>
    /// Simule la consommation d'eau du bâtiment
    /// </summary>
    public void setWaterConsumption() {
        // TODO implement here
    }

    public void getPollutionGenerate() {
        // TODO implement here
    }

    /// <summary>
    /// Simule la pollution générée par le bâtiment
    /// </summary>
    public abstract void setPollutionGenerate();

    public void getLevel() {
        // TODO implement here
    }

    public void setLevel() {
        // TODO implement here
    }

    public void getEmploymentRate() {
        // TODO implement here
    }

    public void setEmploymentRate() {
        // TODO implement here
    }

    public void getTax() {
        // TODO implement here
    }

    public void setTax() {
        // TODO implement here
    }

    public void getMaintenance() {
        // TODO implement here
    }

    public void setMaintenance() {
        // TODO implement here
    }

}