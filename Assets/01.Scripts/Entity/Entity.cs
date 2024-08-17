using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimationTriggerEnum
{
    EndTrigger = 1,
    AttackTrigger = 2,
    EffectTrigger = 4
}
public abstract class Entity : MonoBehaviour
{
    public Animator AnimatorCompo { get; protected set; }
    public SpriteRenderer RendererCompo { get; protected set; }
    public bool IsFacingRight { get; private set; }
    public event Action<bool> OnFlipEvent;
    public WeaponSO CurrentWeapon { get; protected set; }

    protected virtual void Awake()
    {
        Transform visualTrm = transform.Find("Visual");
        AnimatorCompo = visualTrm.GetComponent<Animator>();
        RendererCompo = visualTrm.GetComponent<SpriteRenderer>();
    }

    public void Flip(bool value)
    {
        float yRot = value ? 180f : 0f;
        transform.rotation = Quaternion.Euler(0f, yRot, 0f);
        OnFlipEvent?.Invoke(value);
        IsFacingRight = !value;
    }

    public abstract void AnimationTrigger(AnimationTriggerEnum triggerBit);
}
