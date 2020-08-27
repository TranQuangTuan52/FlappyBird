using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bir : MonoBehaviour

{
    public float bounceForce;
    private Rigidbody2D myBody;
    private Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        BirdMovement();
    }
    void BirdMovement()
    {
        if (Input.GetMouseButtonDown(0))//left
        {
            myBody.velocity = new Vector2(myBody.velocity.x, bounceForce);
        }
    }
}
