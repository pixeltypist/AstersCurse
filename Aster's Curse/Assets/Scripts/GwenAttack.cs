using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GwenAttack : MonoBehaviour
{
    // the thing stopping the animation is keyed into the animation itself by an event
    Animator anim;
    Vector2 aimedPoint;
    [SerializeField]Transform throwPoint;
    [SerializeField]GameObject potion;
    [SerializeField]float potionRange;
    [SerializeField]Camera cam;
    public Vector2 potionAimedPoint;
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
        anim.SetBool("isAttacking", true);
        aimedPoint = cam.ScreenToWorldPoint(Input.mousePosition); 
        potionAimedPoint = aimedPoint;
        aimedPoint.Normalize();
        anim.SetFloat("MouseX", aimedPoint.x);
        anim.SetFloat("LastMovedX", aimedPoint.x);
        anim.SetFloat("MouseY", aimedPoint.y);
        anim.SetFloat("LastMovedY", aimedPoint.y);
        throwingPotion = true;
    }

    public void FinishAttack(){
        anim.SetBool("isAttacking", false);
        if (throwingPotion){
            //figure out which point to use
            //Instatiate potion at that point.
            UsePotion pot = Instantiate(potion, throwPoint.position, Quaternion.identity).GetComponent<UsePotion>();
            pot.GetComponent<UsePotion>().PassPotionTarget(potionAimedPoint);
            throwingPotion = false;           
        }
    }
}
