using UnityEngine;

public class DotProduct: MonoBehaviour
{
    public Vector3 vectorA = new Vector3(1, 0, 0);
    public Vector3 vectorB = new Vector3(0, 1, 0);

    void Start()
    {
        float dotProduct = Vector3.Dot(vectorA, vectorB);
        Debug.Log("Dot Product of " + vectorA + " and " + vectorB + " is: " + dotProduct);
    }
}

