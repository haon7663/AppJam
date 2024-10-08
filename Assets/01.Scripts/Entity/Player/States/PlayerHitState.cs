using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitState : State<Player>
{
    public PlayerHitState(Player owner, StateMachine<Player> stateMachine, string animBoolName) : base(owner, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
        _owner.SetInvincible(1f);
        _owner.MovementCompo.StopImmediately();
    }

    public override void UpdateState()
    {
        if (IsTriggerCalled(AnimationTriggerEnum.EndTrigger))
        {
            _stateMachine.ChangeState(PlayerStateEnum.Idle);
        }
    }
}
