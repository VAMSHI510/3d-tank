using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : EnemyStateMachine
{
    private Collider[] Player;
    public override void OnEnterState()
    {
        base.OnEnterState();
        Player = Physics.OverlapSphere(transform.position, attackingRange, player);
        if (Player[0] != null)
            enemy.MoveTurret(Player[0].transform);
        enemy.ShootDelay(1f);

    }
    public override void OnExitState()
    {
        base.OnExitState();

    }
}
