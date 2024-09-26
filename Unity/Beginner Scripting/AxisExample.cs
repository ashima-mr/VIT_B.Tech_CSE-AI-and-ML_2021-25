using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class DualAxisExample : MonoBehaviour 
{
    public TMP_Text horizontalValueDisplayText;
    public TMP_Text verticalValueDisplayText;
    public float hRange;
    public float vRange;
    
    void Update ()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;
        
        transform.position = new Vector3(xPos, 0, yPos);
        horizontalValueDisplayText.text = h.ToString("F2");
        verticalValueDisplayText.text = v.ToString("F2");
    }
}