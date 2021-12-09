using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball4 : MonoBehaviour
{
    public float speed = 5f;
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector2(1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        {
            if (transform.position.x > 10 || transform.position.x < -10)
            {
                transform.position = new Vector2(0, 0);
            }
       }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Paddle")
        {
            direction.x *= -1;
        }
        else
        {
            direction.y *= -1;
        }
    }
}
