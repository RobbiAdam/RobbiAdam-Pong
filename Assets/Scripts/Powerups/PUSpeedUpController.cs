using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float magnitude;
    
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision == ball)
        {
            Debug.Log("Speed Boost Active");
            ball.GetComponent<BallController>().ActiveSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
        
    }

}
