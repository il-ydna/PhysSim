using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Transform ball;
    public Vector3 offset;
    private bool hasBall = true;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = ball.position + offset;
        }
        if (hasBall)
        {
            transform.position = player.position + offset;
        }

    }
}
