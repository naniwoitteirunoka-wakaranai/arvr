using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light myLight;

    Color targetColor;
    float targetIntensity;

    void Start()
    {
        myLight = GetComponent<Light>();
        targetColor = myLight.color;
        targetIntensity = myLight.intensity;
    }

    void Update()
    {
        // Press 1 → Yellow light
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            targetColor = Color.yellow;
            targetIntensity = 2f;
        }

        // Press 2 → Cyan light
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            targetColor = Color.cyan;
            targetIntensity = 4f;
        }

        // Press 3 → Green light
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            targetColor = Color.green;
            targetIntensity = 1f;
        }

        // THIS is the "animation" part (smooth change)
        myLight.color = Color.Lerp(myLight.color, targetColor, Time.deltaTime * 2);
        myLight.intensity = Mathf.Lerp(myLight.intensity, targetIntensity, Time.deltaTime * 2);
    }
}
