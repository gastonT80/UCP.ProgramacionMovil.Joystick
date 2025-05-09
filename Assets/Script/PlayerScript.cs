using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed;

    public FixedJoystick joystick;

    [SerializeField] Animator anim;
    Vector3 move;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0).normalized;

        move.x = joystick.Horizontal;
        move.y = joystick.Vertical;


       
        anim.SetFloat("Horizontal", move.x);
        anim.SetFloat("Vertical", move.y);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + (move * speed * Time.fixedDeltaTime));    
 
    
    }
}
