using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed;
    public KeyCode UpKey;
    public KeyCode DownKey;
    private Rigidbody2D rb;
    private float speedBoost = 1f;
    private float boostDuration = 2f;
    private float lengthBoost = 1f;
    private float lengthDuration = 5f;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        //get input
        if (Input.GetKey(UpKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(DownKey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        rb.velocity = movement * speedBoost;
    }

    public void ActivateSpeedBoost(float magnitude)
    {

        speedBoost *= 2;
        StartCoroutine(PaddleBoostDownRoutine());

    }

    private IEnumerator PaddleBoostDownRoutine()
    {
        yield return new WaitForSeconds(boostDuration);
        speedBoost /= 2;

    }

    public void ActivateLengthBoost(float magnitude)
    {
        transform.localScale += new Vector3(0, lengthBoost, 0);
        StartCoroutine(PaddleLengthBoostDownRoutine());
    }

    private IEnumerator PaddleLengthBoostDownRoutine()
    {
        yield return new WaitForSeconds(lengthDuration);
        transform.localScale -= new Vector3(0, lengthBoost, 0);
    }

}
