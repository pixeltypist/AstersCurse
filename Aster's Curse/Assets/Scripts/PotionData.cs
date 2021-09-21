using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Potion", menuName = "ScriptableObjects/Potion")]
public class PotionData : ScriptableObject
{
    public float range, speed, baseDamage;
    public Sprite sprite;
    public Animator anim;
    public enum Element{
        Earth,
        Water,
        Air,
        Fire,
        Dark,
        Light,
        Soul
    };
    public Element element;
}
