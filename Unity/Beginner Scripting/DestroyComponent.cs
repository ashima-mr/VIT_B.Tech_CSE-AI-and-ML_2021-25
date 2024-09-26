using UnityEngine;
using System.Collections;

public class DestroyComponent : MonoBehaviour
{
    void Update ()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}
