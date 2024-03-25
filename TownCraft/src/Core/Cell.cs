
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Cell : City {

    public Cell() {
    }

    public int x;

    public int y;

    public string type;

    public boolean available;

    public Infrastructure infrastructure;

    public Building building;

    /// <summary>
    /// @return
    /// </summary>
    public string getType() {
        // TODO implement here
        return "";
    }

    /// <summary>
    /// @return
    /// </summary>
    public boolean isAvailable() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param infrastructure
    /// </summary>
    public void setInfrastructure(Infrastructure infrastructure) {
        // TODO implement here
    }

    /// <summary>
    /// @param building
    /// </summary>
    public void setBuilding(Building building) {
        // TODO implement here
    }

    /// <summary>
    /// @return
    /// </summary>
    public Infrastructure getInfrastructure() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public Building getBuilding() {
        // TODO implement here
        return null;
    }

}