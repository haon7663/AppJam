using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonEnemyDeadState : State<CommonEnemy>
{
    public CommonEnemyDeadState(CommonEnemy owner, StateMachine<CommonEnemy> stateMachine, string animBoolName) : base(owner, stateMachine, animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
        _owner.gameObject.layer = 8;
    }

    public override void UpdateState()
    {
        if (IsTriggerCalled(AnimationTriggerEnum.EndTrigger))
        {
            _owner.Kill();
        }
    }
}
