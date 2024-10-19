using UnityEngine;

public class WeatherChanger : MonoBehaviour
{
    // You can call this method at any time to trigger the rain
    public void TriggerHeavyRain()
    {
        // Assuming the preset name is exactly "Heavy Rain"
        EnviroSkyMgr.instance.ChangeWeather("Heavy Rain");
    }
}
