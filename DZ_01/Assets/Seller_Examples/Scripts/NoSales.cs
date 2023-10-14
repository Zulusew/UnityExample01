using UnityEngine;

public class NoSales : ISell
{
    public void Sell()
    {
        Debug.Log("Нельзя торговать");
    }

}
