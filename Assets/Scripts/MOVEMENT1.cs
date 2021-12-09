using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVEMENT1 : MonoBehaviour
{
    private void Update()
    {
        float movement = Input.GetAxisRaw("Vertical");

        transform.position = new Vector3(transform.position.x, transform.position.y + movement, transform.position.z);
    }
}
