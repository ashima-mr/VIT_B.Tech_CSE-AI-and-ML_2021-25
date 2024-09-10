using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;

public class ExampleBehaviourScript : MonoBehaviour
{
    private Color originalColor;
      void Start()
    {
        // Store the original color of the GameObject
        originalColor = GetComponent<Renderer>().material.color;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer> ().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.W))  // Choose a key to reset the color
        {
            GetComponent<Renderer>().material.color = originalColor;
        }
    }
}
