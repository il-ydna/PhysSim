using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    public Rigidbody rb;
    public Rigidbody pl;
    public float throwForce = 50f;
    public float jumpForce = 10f;
    public Vector3 BallMovement;
    public Vector3 PlayMovement;
    public float throwAngle = 45;
    private bool thrown;
    private float pi = 3.14159265f;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            thrown = true;
            Debug.Log("space pressed");
        }
        
    }
    void FixedUpdate()
    {
        if (thrown)
        {
            Debug.Log("no more");
            float throwRad = throwAngle * pi/180;
            Debug.Log(throwRad);
            pl.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            rb.AddForce(Vector3.up * Mathf.Sin(throwRad) * throwForce, ForceMode.VelocityChange);
            rb.AddForce(Vector3.right * Mathf.Cos(throwRad) * throwForce, ForceMode.VelocityChange);

            //BallMovement = new Vector3(throwForce * Mathf.Cos(throwRad), throwForce * Mathf.Sin(throwRad), 0);
            //rb.transform.position += BallMovement * Time.deltaTime;

            thrown = false;
        }
    }
}
