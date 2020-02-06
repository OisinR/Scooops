using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    bool mL = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //mL = !mL;
        }
        if (mL)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
