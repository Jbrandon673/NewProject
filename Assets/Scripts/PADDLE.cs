using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PADDLE : MonoBehaviour
{

    // Update is called once per frame
    public void Update() {

        float movement = Input.GetAxisRaw("Vertical");

        transform.position = new Vector3(transform.position.x, transform.position.y + movement, transform.position.z);
    }
}
