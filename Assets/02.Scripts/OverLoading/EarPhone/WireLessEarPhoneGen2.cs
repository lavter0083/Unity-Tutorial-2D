using UnityEngine;

public class WireLessEarPhoneGen2 : WireLessEarPhone
{
    public bool isNoiseCancelling;

    private void Start()
    {
        name = "AirPod2";
        price = 120f;
        releaseYear = 20010;
        batterySize = 100f;

    }

    public virtual void NoiseCanelling()
    {
        isNoiseCancelling = !isNoiseCancelling;
        string msg = isNoiseCancelling ? "노이즈 캔슬 On" : "노이즈 캔슬링 OFF";
        Debug.Log(msg);
    }
}
