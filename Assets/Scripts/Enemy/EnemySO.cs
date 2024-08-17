using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/EnemySO", fileName = "EnemySO")]
public class EnemySO : ScriptableObject
{
    public float maxHp;
    public float moveSpeed;
    public Rect rect;
}
