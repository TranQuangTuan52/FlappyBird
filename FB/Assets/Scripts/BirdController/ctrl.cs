using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class ctrl : MonoBehaviour

{
    public float bounceForce;
    private Rigidbody2D myBody;
    private Animator anim;

    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip flyClip, pingClip, dieClip;

   
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
        _BirdMovement();
    }
    void _BirdMovement()
    {



        if (Input.GetMouseButtonDown(0))
        {
            myBody.velocity = new Vector2(myBody.velocity.x, bounceForce);
            audioSource.PlayOneShot(flyClip);
        }

        if (myBody.velocity.y > 0)
        {
            float fAngel = 0;
            fAngel = Mathf.Lerp(0, 90, myBody.velocity.y / 7);
            transform.rotation = Quaternion.Euler(0, 0, fAngel);
        }
        else if (myBody.velocity.y == 0)
            transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (myBody.velocity.y < 0)
        {
            float fAngel = 0;
            fAngel = Mathf.Lerp(0, -90, -myBody.velocity.y / 7);
            transform.rotation = Quaternion.Euler(0, 0, fAngel);
        }
    }

    
}
