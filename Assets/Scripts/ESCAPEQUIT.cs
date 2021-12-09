using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESCAPEQUIT : MonoBehaviour
{

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

    }

}