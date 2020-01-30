using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [Header("movement")]
    [SerializeField] private float speed = 15f;     //Creates a 'speed' field in unity under movement Class
    [SerializeField] private float jumpForce = 10f; //Creates a 'jumpForce field in Unity under movement Class
    [SerializeField] private Vector2 ground_collision;//creates a moveable point for ground collision detection

    private float move;

    private bool jump;
    private bool onGround;
    
    public LayerMask groundLayer;
    [SerializeField] private float radius;
    [SerializeField] private float angle;
    CapsuleDirection2D 
    
    private Rigidbody2D rb2d;                       // Create a 2D rigid body class instance
    
    void Start()                                    // Start is called before the first frame update
    {
        rb2d = GetComponent<Rigidbody2D>();         //Attaches rigid body 2D in Unity to the variable 'rb2d'
    }

   
    void Update()                                   // Update is called once per frame
    {
        move = Input.GetAxis("Horizontal");
        jump = Input.GetButtonDown("Jump");
        onGround = Physics2D.OverlapCapsule((Vector2)transform.position + ground_collision, radius, groundLayer);
        if (onGround && jump)
            rb2d.velocity = new Vector2(move * speed, jumpForce);
        else
            rb2d.velocity = new Vector2(move * speed, rb2d.velocity.y);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        var positions = new Vector2[] {ground_collision };

        Gizmos.DrawWireSphere((Vector2)transform.position + ground_collision, radius);
    }
}
