using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public EnemyData data;
    public float damage;
    GameObject player;
    float distanceToPlayer;
    void Start()
    {
        damage = data.baseAttack;
        player = FindObjectOfType<GwenAttack>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(distanceToPlayer < data.baseSensingRange){
            print("Player detected");
        }
    }

    private void FixedUpdate() {
        Vector2 distance = player.transform.position - transform.position;
        distanceToPlayer = distance.magnitude;
    }
}
