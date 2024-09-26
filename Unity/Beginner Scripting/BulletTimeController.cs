using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTimeTrigger : MonoBehaviour
{
    public BulletTime bulletTimeController;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            bulletTimeController.StartBulletTime();
        }
    }
}

