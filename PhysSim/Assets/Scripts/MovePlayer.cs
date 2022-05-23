using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private LayerMask playerMask;

    public Rigidbody rb;
    public Rigidbody feet;
    public float moveForce = 500f;
    public Vector3 Movement;
    private bool onGround = false;


    // Update is called once per frame
    void Update()
    {
        //Movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        
    }

    void FixedUpdate()
    {
        if (Physics.OverlapSphere(feet.position, 0.01f, playerMask).Length == 0)
        {
            rb.transform.position += Movement * moveForce * Time.deltaTime;
            
            return;
        }
        else
        {
            Movement = new Vector3(0, 0, 0);
            Debug.Log("no one colliding!");

        }
    }
    
}
