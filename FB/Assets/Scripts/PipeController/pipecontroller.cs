using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipecontroller : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _PipeMovement();
        
    }
    public void _PipeMovement()
    {
        Vector3 temp = transform.position;
        temp.x -= speed * Time.deltaTime;
        transform.position = temp;
    }

    void OnCollisionEnter2D(Collision2D collision)//khong co isTrigger
    {

    }
    void OnTriggerEnter2D(Collider2D collision)//1 trong 2 isTrigger = true
    {
        if (collision.tag.Equals("Destroy"))
        {
            Destroy(gameObject);
        }
    }
}
