using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GwenAttack : MonoBehaviour
{
    // the thing stopping the animation is keyed into the animation itself by an event
    Animator anim;
    Vector2 throwPoint;
    [SerializeField]GameObject potion;
    [SerializeField]float potionRange;
    [SerializeField]Camera cam;
    bool throwingPotion;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            ThrowPotion();
        }
    }

    void ThrowPotion(){
        print("Entered ThrowPotion()");
        anim.SetBool("isAttacking", true);
        throwPoint = cam.ScreenToWorldPoint(Input.mousePosition); 
        throwPoint.Normalize();
        anim.SetFloat("MouseX", throwPoint.x);
        anim.SetFloat("LastMovedX", throwPoint.x);
        anim.SetFloat("MouseY", throwPoint.y);
        anim.SetFloat("LastMovedY", throwPoint.y);
        throwingPotion = true;

    }

    public void FinishAttack(){
        anim.SetBool("isAttacking", false);
        if (throwingPotion){
            //figure out which point to use
            //Instatiate potion at that point.

            //set throwingPotion to false            
        }
    }
}
