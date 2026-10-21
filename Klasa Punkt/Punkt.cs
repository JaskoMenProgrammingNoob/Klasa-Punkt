using System.Runtime.CompilerServices;
using System;
public class Punkt
{
    public int x;
    public int y;

    public void UstawWspolrzedne(int wspX, int wspY)
    {
        x = wspX;
        y = wspY;
    }
    public Punkt PobierzWspolrzedne()
    {
        Punkt punkt = new Punkt();
        punkt.x = x;
        punkt.y = y;
        return punkt;

    }



}
