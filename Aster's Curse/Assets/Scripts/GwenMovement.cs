using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GwenMovement : MonoBehaviour
{
    Rigidbody2D rb;
    float movementX, movementY;
    [SerializeField]float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        movementY = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate() 
    {
        Vector2 movementVector = new Vector2(movementX, movementY);
        rb.MovePosition(rb.position + movementVector * Time.deltaTime * speed);
    }
}
