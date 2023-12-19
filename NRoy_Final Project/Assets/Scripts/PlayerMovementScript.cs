using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovementScript : MonoBehaviour
{
    public Rigidbody playerBody;
    public float jumpAmount;
    public float groundDistance = 0.6f;
    Animator anim;
    public bool frontView;
    // Start is called before the first frame update
    void Start()
    {
        frontView = true;
        anim = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (frontView == true)
        {
            if(Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(0f, 0f, -0.02f);
            }
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(0f, 0f, 0.02f);
            }
            if(Input.GetKey(KeyCode.UpArrow) && isGrounded())
            {
                playerBody.velocity = Vector3.up * jumpAmount;
            }
        }
        if (frontView == false) 
        {
            if(Input.GetKey(KeyCode.UpArrow) && isGrounded())
            {
                playerBody.velocity = Vector3.up * jumpAmount;
            }
        }
    }
    bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, groundDistance);
    }
}
