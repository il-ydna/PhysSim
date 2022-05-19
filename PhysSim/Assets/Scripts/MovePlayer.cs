using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public Rigidbody rb;
    public float moveForce = 500f;
    public Vector3 Movement;

    // Update is called once per frame
    void Update()
    {
        //Movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        
    }

    void FixedUpdate()
    {
        rb.transform.position += Movement * moveForce * Time.deltaTime;
    }
    
}
