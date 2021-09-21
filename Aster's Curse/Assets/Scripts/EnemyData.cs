using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/EnemyData")]
public class EnemyData : ScriptableObject {
    public float health, baseAttack, baseSensingRange, baseSpeed;
    public Sprite sprite;

    public enum Element{
        Earth,
        Water,
        Fire,
        Air,
        Light,
        Dark,
        Soul
        
    }
    public Element element;

    public enum EnemyBehavior{
        Normal,
        Timid,
        Ranged,
        Melee
    }
    public EnemyBehavior behavior; 
}
