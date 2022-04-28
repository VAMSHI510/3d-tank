using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : EnemyStateMachine
{
    private Collider[] Player;

    public override void OnEnterState()
    {
        base.OnEnterState();
        Player = Physics.OverlapSphere(transform.position, chasingRange, player);
        if (Player[0] != null)
        {
            agent.SetDestination(Player[0].transform.position);
            enemy.MoveTurret(defaultTransform);
        }

    }
    public override void OnExitState()
    {
        base.OnExitState();


    }
}
