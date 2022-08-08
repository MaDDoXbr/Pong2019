using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {
    public KeyCode UpKey, DownKey;
    public Rigidbody2D rigidbody;
    public float VerticalSpeed = 7f;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(UpKey))
            rigidbody.velocity = new Vector2(0, VerticalSpeed);
        else if (Input.GetKey(DownKey))
            rigidbody.velocity = new Vector2(0, -VerticalSpeed);
        else {
            rigidbody.velocity = Vector2.zero;
        }
    }
}
