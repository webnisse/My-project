using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mvement : MonoBehaviour
{
    public float speed;

    private float Move;

    public float jumpAmount = 10;

    private Rigidbody2D rb;

    bool hasJumped = false;

    public Transform checker;

    public LayerMask groundlayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {


        Move = Input.GetAxis("Horizontal");

        bool isGrounded = Physics2D.OverlapCircle(checker.position, 0.5f, groundlayer);





        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if (Input.GetAxisRaw("Vertical") > 0 && hasJumped == false && isGrounded)
        {

            rb.AddForce(Vector2.up * jumpAmount);
            hasJumped = true;
        }

        if (Input.GetAxisRaw("Vertical") == 0)
        {
            hasJumped = false;
        }

        // rb.velocity = new Vector2(speed * jumpAmount, rb.velocity.x);


    }
}
