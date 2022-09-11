using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    float mx;
       public float MovementSpeed = 5f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");

    }
    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * MovementSpeed, rb.velocity.y);
        rb.velocity   = movement;
    }
    


}
