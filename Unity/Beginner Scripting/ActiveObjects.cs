using UnityEngine;
using System.Collections;

public class ActiveObjects : MonoBehaviour
{
    void Update() {
        if(Input.GetKey(KeyCode.A)){
            gameObject.SetActive(false);
        }
        else if(Input.GetKey(KeyCode.P)){
            gameObject.SetActive(true);
        }
    }
}
