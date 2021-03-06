using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public float jumpSpeed = 100f;
    public Rigidbody2D rb;
    Vector2 movement;
    Vector2 lastClickedPos;
    public bool moving;

    public Animator animator;
    public int level = 0;

    public GameObject respawnPoint0;
    public GameObject respawnPoint1;
    public GameObject respawnPoint2;
    public GameObject respawnPoint3;

    // Update is called once per frame
    void Update()
    {
        //inputs
        

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null && hit.collider.tag == "Log" && Input.GetMouseButtonDown(0))
        { 
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
        if (transform.position.y >= 44)
        {
            level = 3;
        }
        else if (transform.position.y >= 27)
        {
            level = 2;
        }
        else if (transform.position.y >= 10)
        {
            level = 1;
        }

    }
    private void FixedUpdate()
    {
        //movements
        if(!moving)
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void respawn(int lev)
    {
        Vector3 a = transform.position;
        Vector3 b = respawnPoint0.transform.position;
        Vector3 c = respawnPoint1.transform.position;
        Vector3 d = respawnPoint2.transform.position;
        Vector3 e = respawnPoint3.transform.position;
        if (lev == 0)
        {
            transform.position = Vector3.MoveTowards(a, b,100);
        }
        else if (lev == 1)
        {
            transform.position = Vector3.MoveTowards(a, c,100);
        }
        else if (lev == 2)
        {
            transform.position = Vector3.MoveTowards(a, d,100);
        }
        else if (lev == 3)
        {
            transform.position = Vector3.MoveTowards(a, e, 100);
        }
    }

}
