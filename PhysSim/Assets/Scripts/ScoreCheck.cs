using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball")
        {
            score++;
        }
    }
}
