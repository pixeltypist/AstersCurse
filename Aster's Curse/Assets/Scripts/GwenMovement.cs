using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GwenMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    float movementX, movementY;
    [SerializeField]float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        anim=this.GetComponent<Animator>();
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
        rb.MovePosition(rb.position + movementVector * Time.fixedDeltaTime * speed);
        AdjustAnimation();
    }

    void AdjustAnimation(){
        //logic for setting idle you'll end on
        /*if(movementX!=0){
            anim.SetBool("LastMovedHorizontal", true);
        }
        else if(movementX == 0){
            anim.SetBool("LastMovedHorizontal", false);
        }
        else if(movementY!=0){
            anim.SetBool("LastMovedVertical",true);
        }
        else if(movementY == 0){
            anim.SetBool("LastMovedVertical", false);
        }*/

        //logic for determining idle
        anim.SetFloat("Horizontal", movementX);
        anim.SetFloat("Vertical", movementY);
        if(movementX != 0 | movementY != 0){
            anim.SetBool("isMoving", true);
            anim.SetFloat("LastMovedX", movementX);
            anim.SetFloat("LastMovedY", movementY);
        }
        else{
            anim.SetBool("isMoving", false);
        }
    }
}
