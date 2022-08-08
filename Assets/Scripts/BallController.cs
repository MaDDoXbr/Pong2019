using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public Vector2 Speed = new Vector2(5, 3);
    public Vector2 StartPos;
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    
    void Start()
    {
        PickDirection();
        StartPos = transform.position;
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        var paddle = collision2D.collider.GetComponent<PaddleController>();
        if (paddle == null) 
            return;
        rigidbody.velocity = new Vector2(rigidbody.velocity.x > 0 ? Speed.x : -Speed.x, 
                                         rigidbody.velocity.y );
    }

    public void PickDirection()
    {
        var direction = Random.Range(0, 2);
        if (direction == 0) {
            rigidbody.velocity = new Vector2(Speed.x, -Speed.y);
        } else {
            rigidbody.velocity = new Vector2(-Speed.x, Speed.y);
        }
    }

    public void ResetPosition()
    {
        transform.position = StartPos;
        PickDirection();
    }
}
