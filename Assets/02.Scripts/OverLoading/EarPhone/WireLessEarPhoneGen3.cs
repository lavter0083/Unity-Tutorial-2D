using UnityEngine;

public class WireLessEarPhoneGen3 : WireLessEarPhoneGen2
{
    public enum NoiseCancelType { Off, On, Around}
    public NoiseCancelType noiseCancelType;

    private void Start()
    {
        name = "AirPod3";
        price = 100f;
        releaseYear = 2015;
        batterySize = 170f;

    }

    public void SetNoiseCancelType(NoiseCancelType type)
    {
        noiseCancelType = type;
    }

    public override void NoiseCanelling()
    {
        SetNoiseCancelType(noiseCancelType);
        base.NoiseCanelling();
    }
}
