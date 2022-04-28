using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BattleTank
{
    public class EnemyController
    {
        internal float chaseRange;
        internal float attackRange;
        internal LayerMask IsPlayer;

        public EnemyModel EnemyModel { get; private set; }
        public EnemyView EnemyView { get; private set; }

        public EnemyController(EnemyModel enemyModel, GameObject enemyPrefab)
        {
            EnemyModel = enemyModel;
            GameObject tank = GameObject.Instantiate(enemyPrefab);
            EnemyView = tank.gameObject.GetComponent<EnemyView>();
            EnemyView.SetEnemyController(this);
            EnemyModel.SetEnemyController(this);
        }

        public void Fire(GameObject shell, Transform fireTransform)
        {
            GameObject gameObject = GameObject.Instantiate(shell, fireTransform.position, fireTransform.rotation);
            Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();
            rigidbody.velocity = EnemyModel.m_LaunchForce * fireTransform.forward;
        }
    }
}
