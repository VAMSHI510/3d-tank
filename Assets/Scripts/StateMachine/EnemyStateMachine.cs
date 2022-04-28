using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using BattleTank;

[RequireComponent(typeof(EnemyView))]
public class EnemyStateMachine : MonoBehaviour
{
    protected EnemyView enemy;
    protected NavMeshAgent agent;

    protected Transform defaultTransform;

    public EnemyController EnemyController { get; private set; }

    protected float chasingRange = 15f, attackingRange = 9f;

    protected LayerMask player;
    protected EnemyController enemyCotroller;
    protected void Awake()
    {
        enemy = GetComponent<EnemyView>();
        agent = GetComponent<NavMeshAgent>();
    }
    private void Start()
    {
        defaultTransform = enemy.GetTransform();
    }
    private void OnEnable()
    {
        EnemyController = GetComponent<EnemyController>();
        chasingRange = EnemyController.chaseRange;
        attackingRange = EnemyController.attackRange;
        player = EnemyController.IsPlayer;

    }
   
    public virtual void OnEnterState()
    {
        this.enabled = true;
    }
    public virtual void OnExitState()
    {
        this.enabled = false;
    }

}
