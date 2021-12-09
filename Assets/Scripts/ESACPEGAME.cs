using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESACPEGAME : MonoBehaviour
{
    void Update()

    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape key was pressed");
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Debug.Log("Escape key was released");
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Escape key is being pressed");
        }
    }
}