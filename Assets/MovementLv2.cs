using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLv2 : MonoBehaviour
{
    public float speed;
    private float Move;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(moveX, moveY) * speed;


        // rb.velocity = new Vector2(rb.velocity.x, speed * Move);

    }
}
