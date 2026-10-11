using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed;
     public float jumpHeight;
     public KeyCode Spacebar;
     public KeyCode L;
     public KeyCode R;
     public Transform groundCheck;
     public float groundCheckRadius;
     public LayerMask WhatIsGround;
     private bool isGrounded;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){


        if(Input.GetKey(L))
        {
            GetComponent<Rigidbody2D>().velocity =new Vector2(-moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
            if( GetComponent<SpriteRenderer>()!=null)
        {
            GetComponent<SpriteRenderer>().flipX=true;
        }
    }
        if(Input.GetKey(R))
        {
            GetComponent<Rigidbody2D>().velocity =new Vector2(moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
           if( GetComponent<SpriteRenderer>()!=null)
           {
      GetComponent<SpriteRenderer>().flipX=false;

           }

    }

         if(Input.GetKeyDown(Spacebar) && isGrounded)
        {
           
            jump();
        }
  }



         void jump(){
           GetComponent<Rigidbody2D>().velocity =new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
            Debug.Log("JUMP");
        }

    void FixedUpdate()
        {
            isGrounded =Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,WhatIsGround);
        }
}