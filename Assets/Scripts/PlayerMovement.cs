using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int PV = 3;

    public GameObject key;
    public GameObject coffre;

    public float moveSpeed;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 moveDirection;

    void Update()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");
        moveDirection = moveDirection.normalized;

        animator.SetFloat("Horizontal", moveDirection.x);
        animator.SetFloat("Vertical", moveDirection.y);
        animator.SetFloat("Speed", moveDirection.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "boule")
        {
            PV = PV - 1;
            Debug.Log(PV);
        }
        if (collider.tag == "coffre")
        {
            key.SetActive(true);
            coffre.SetActive(false);
        }
    }
}
