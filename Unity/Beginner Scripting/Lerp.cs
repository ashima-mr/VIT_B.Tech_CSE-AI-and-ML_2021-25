using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    // Variables to test Lerp functions
    public Light lightComponent;  // Reference to the Light component
    public Color colorFrom = Color.red;
    public Color colorTo = Color.blue;
    public Vector3 vectorFrom = new Vector3(1f, 2f, 3f);
    public Vector3 vectorTo = new Vector3(5f, 6f, 7f);

    private void Update()
    {
        // Example of Vector3.Lerp
        Vector3 lerpedVector = Vector3.Lerp(vectorFrom, vectorTo, 0.75f);
        Debug.Log("Vector3.Lerp result: " + lerpedVector);

        // Example of Color.Lerp
        Color lerpedColor = Color.Lerp(colorFrom, colorTo, 0.75f);
        GetComponent<Renderer>().material.color = lerpedColor;

        // Example of smoothing light intensity
        if (lightComponent != null)
        {
            lightComponent.intensity = Mathf.Lerp(lightComponent.intensity, 8f, 0.5f * Time.deltaTime);
        }
    }
}
