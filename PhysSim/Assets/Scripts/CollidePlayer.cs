using UnityEngine;

public class CollidePlayer : MonoBehaviour
{
    
    public MovePlayer movement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            movement.enabled = false;
        }
    }
}
