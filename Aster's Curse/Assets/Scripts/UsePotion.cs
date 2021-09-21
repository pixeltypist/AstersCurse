using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePotion : MonoBehaviour
{
    /*
    I seem to be having a problem with passing the position of the mouse for use in the Update ._.
    */
    [SerializeField]PotionData potion;
    float range, speed;
    Sprite sprite;
    Animator anim;
    bool isActive;
    Vector2 potionTrajectory;
    Rigidbody2D rb;
    Vector2 startPos;
    private void Start() {
        range = potion.range;
        sprite = potion.sprite; // this should actually probably set the sprite for the game object??
        //anim = potion.anim;
        speed = potion.speed;
        rb = GetComponent<Rigidbody2D>();
    }

    public void PassPotionTarget(Vector3 mousePoint){
        startPos = GetComponent<Transform>().position;
        potionTrajectory = mousePoint-GetComponent<Transform>().position;
    }
    private void FixedUpdate() {
        //target point never makes it *here*
        
        if (potionTrajectory != new Vector2(0,0)){
            PotionThrow();
            LimitRange();
        }
    }



    void PotionThrow(){
        rb.velocity = potionTrajectory*speed;
    }

    void LimitRange(){
        Vector2 distance = new Vector2 (GetComponent<Transform>().position.x, GetComponent<Transform>().position.y) - startPos;
        float length = distance.magnitude;
        if(length>range){
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D obj) {
        print("Collision");
        if(obj.gameObject.CompareTag("Enemy")){
            obj.gameObject.GetComponent<HealthManager>().Attacked(potion.baseDamage);
        }
    }

}
