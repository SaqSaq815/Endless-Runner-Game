using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public float JumpForce;

    private Rigidbody2D myRigidody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidody = GetComponent<RigidBody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myRigidody.velocity = new Vector2();
    }
}
