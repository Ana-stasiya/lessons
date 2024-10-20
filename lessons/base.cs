using System;

class Building
{
    public int floor;
    public int Area;
    public int Occupants;

    public int AreaPerPerson()
    {
        return Area / Occupants;
    }
}
