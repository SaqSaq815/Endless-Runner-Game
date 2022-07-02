using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float JumpForce;

    private Rigidbody2D myRigidody;

    public bool grounded;
    public LayerMask whatIsGround;

    private Collider2D myCollider;

    private Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myRigidody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);

        myRigidody.velocity = new Vector2(moveSpeed, myRigidody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) // change these fo swipes for mobile!!
        {
            if(grounded)
            {
                myRigidody.velocity = new Vector2(myRigidody.velocity.x, JumpForce);
            }
        }

        myAnimator.SetFloat("Speed", myRigidody.velocity.x);
        myAnimator.SetBool("Grounded", grounded);
    }
}
