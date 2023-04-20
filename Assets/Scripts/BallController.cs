using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public int speed = 5;
    private Rigidbody2D rb;
    private Vector3 startPosition;

    private void Start() {
        
        rb = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
        LaunchRandom();
    }
    // Update is called once per frame
    private void Update()
    {
        

    }
    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.CompareTag("Goal"))
        {
            speed = 5;
            transform.position = startPosition;
            LaunchRandom();
        }
    }

    private void LaunchRandom()
    {

    int x = Random.Range(0,2) == 0 ? -1 : 1;
    int y = Random.Range(0,2) == 0 ? -1 : 1;

    Vector2 direction = new Vector2(x, y);
    rb.velocity = direction * speed;
    }

    public void ActiveSpeedUp(float magnitude)
    {
        rb.velocity *= 2;
    }

}
