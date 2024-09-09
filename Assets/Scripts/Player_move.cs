using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    Rigidbody rb;
    Vector3 moveVector;
    private Animator _animator;
    public SpriteRenderer spriteRenderer;

    public float speed = 3f;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal") * speed;
        moveVector.z = Input.GetAxis("Vertical") * speed;
        rb.MovePosition(rb.position + moveVector * Time.deltaTime);

        _animator.SetFloat("run_side", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
        if(moveVector.x < 0) spriteRenderer.flipX = true;
        else spriteRenderer.flipX = false;

        if (moveVector.z < 0) _animator.SetBool("run_front", true);
        else _animator.SetBool("run_front", false);

        if (moveVector.z > 0) _animator.SetBool("run_back", true);
        else _animator.SetBool("run_back", false);


    }
}
