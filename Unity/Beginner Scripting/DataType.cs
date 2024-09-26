using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatatypeScript : MonoBehaviour 
{
    void Start () 
    {
        Debug.Log("Start method executed");
        //Value type variable
        Vector3 pos = transform.position;
        pos = new Vector3(-50, 0, 0);
        
        //Reference type variable
        Transform tran = transform;
        tran.position = new Vector3(0, 50, 0);
    }
}
