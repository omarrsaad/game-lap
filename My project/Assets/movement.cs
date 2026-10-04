using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(Spacebar)){
            jump();
        }
        if(Input.GetKey(L)){
            GetComponent<Rigidbody2D>().velocity =new vectory2(-moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
        }
        if(Input.GetKey(R)){
            GetComponent<Rigidbody2D>().velocity =new vectory2(moveSpeed,GetComponent<Rigidbody2D>().velocity.y);
        }
        void jump(
           GetComponent<Rigidbody2D>().velocity =new vectory2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
        )
    }
}
