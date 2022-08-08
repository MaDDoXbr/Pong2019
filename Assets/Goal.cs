using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        var ball = collider.GetComponent<BallController>();
        if (ball == null) 
            return;
        ball.ResetPosition();
    }
}
