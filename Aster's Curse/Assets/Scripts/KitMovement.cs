using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Transform targetPos;
    Rigidbody2D rb;
    Vector2 dir;
    [SerializeField]float buffer, speed;
    void Start()
    {
        targetPos = GameObject.Find("KitTarget").transform;
        rb = GetComponent<Rigidbody2D>();
        dir = new Vector2(0,0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        dir = new Vector2(targetPos.position.x - transform.position.x, targetPos.position.y - transform.position.y);
        rb.velocity = dir*speed;
    }
}
