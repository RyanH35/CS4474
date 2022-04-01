using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public float jumpSpeed = 10f;
    public Rigidbody2D rb;
    Vector2 movement;
    Vector2 lastClickedPos;
    bool moving;

    public Animator animator;
    

    private RaycastHit hit;

  

    private void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        //inputs
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        if (Input.GetMouseButtonDown(0)) {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
        }
        if (moving && (Vector2)transform.position != lastClickedPos)
        {
            float step = jumpSpeed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);

        }
        else {
            moving = false;
        }
        

    }
    private void FixedUpdate()
    {
        //movements
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
