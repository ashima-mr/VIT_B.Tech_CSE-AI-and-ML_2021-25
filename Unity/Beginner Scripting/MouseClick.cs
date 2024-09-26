using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown ()
    {
        Debug.Log("Object clicked");
        rb.AddForce(-transform.forward * 500f);
        rb.useGravity = true;
    }

    void OnMouseOver()
{
    Debug.Log("Mouse is over the object");
}

    void OnMouseUp()
    {
        Debug.Log("Mouse released over the object");
    }

}
