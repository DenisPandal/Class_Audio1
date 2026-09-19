using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    private Light myLight;
    public float minIntensity = 0.5f;
    public float maxIntensity = 2.0f;
    public float flickerSpeed = 0.1f;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        if (myLight != null)
        {
            myLight.intensity = Random.Range(minIntensity, maxIntensity);
        }
    }
}