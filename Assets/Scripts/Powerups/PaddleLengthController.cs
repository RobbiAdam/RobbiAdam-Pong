using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleLengthController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    // public GameObject paddle;
    public float magnitude;
    

    private void Start()
    {        
        
    }

      private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision == ball)
        {
            Debug.Log("Paddle Length Boost Active");
            // paddle.GetComponent<PaddleController>().ActivateSpeedBoost(magnitude);
            
            manager.RemovePowerUp(gameObject);
            
        }
    }
}
