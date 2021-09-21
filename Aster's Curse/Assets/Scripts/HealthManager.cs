using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField]float maxHealth;
    float currentHealth;
    void Start()
    {
        if(this.gameObject.CompareTag("Enemy")){
            maxHealth = GetComponent<EnemyAttack>().data.health;
        }
        currentHealth = maxHealth;
    }

    private void Update() {
        if(currentHealth < 0){
            Die();
        }    
    }

    // Update is called once per frame
    public void Attacked(float damage){
        currentHealth -= damage;
        print("Current health: " + currentHealth);
    }

    void Die(){
        print("Dead.");
    }
}
