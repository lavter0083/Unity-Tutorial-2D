using UnityEngine;

public class WireLessEarPhone : EarPhone
{
    public float batterySize;
    public bool isWirelessCharged;

    private void Start()
    {
        name = "AirPod1";
        price = 100f;
        releaseYear = 2007;
        batterySize = 70f;

    }

    public void Charged()
    {
        string msg = isWirelessCharged ? "무선 충전" : "유선 충전";
        Debug.Log(msg);
    }
}
