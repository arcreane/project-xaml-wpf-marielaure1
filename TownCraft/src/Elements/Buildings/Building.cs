using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Elements.Buildings
{
    public abstract class Building : Elements
    {
        public Building()
        {
        }

        public string Name { get; set; }

        public string Category { get; set; }

        public double Area { get; set; }

        public double ConstructionCost { get; set; }

        public double EnergyConsumption { get; set; }

        public double WaterConsumption { get; set; }

        public double PollutionGenerate { get; set; }

        public int Level { get; set; }

        public double Attribute1 { get; set; }

        public double EmploymentRate { get; set; }

        public double Maintenance { get; set; }

        public void GetName()
        {
            // TODO implement here
        }

        public void SetName()
        {
            // TODO implement here
        }

        public void GetCategory()
        {
            // TODO implement here
        }

        public void SetCategory()
        {
            // TODO implement here
        }

        public void GetConstructionCost()
        {
            // TODO implement here
        }

        public void SetConstructionCost()
        {
            // TODO implement here
        }

        public void GetEnergyConsumption()
        {
            // TODO implement here
        }

        /// <summary>
        /// Simule la consommation d'énergie du bâtiment
        /// </summary>
        public void SetEnergyConsumption()
        {
            // TODO implement here
        }

        public void GetWaterConsumption()
        {
            // TODO implement here
        }

        /// <summary>
        /// Simule la consommation d'eau du bâtiment
        /// </summary>
        public void SetWaterConsumption()
        {
            // TODO implement here
        }

        public void GetPollutionGenerate()
        {
            // TODO implement here
        }

        /// <summary>
        /// Simule la pollution générée par le bâtiment
        /// </summary>
        public abstract void SetPollutionGenerate();

        public void GetLevel()
        {
            // TODO implement here
        }

        public void SetLevel()
        {
            // TODO implement here
        }

        public void GetEmploymentRate()
        {
            // TODO implement here
        }

        public void SetEmploymentRate()
        {
            // TODO implement here
        }

        public void GetTax()
        {
            // TODO implement here
        }

        public void SetTax()
        {
            // TODO implement here
        }

        public void GetMaintenance()
        {
            // TODO implement here
        }

        public void SetMaintenance()
        {
            // TODO implement here
        }
    }
}
