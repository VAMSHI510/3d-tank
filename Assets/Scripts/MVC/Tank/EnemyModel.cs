using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BattleTank
{
    public class EnemyModel
    {
        private EnemyController enemyController;
        public EnemyModel(EnemyScriptableObject enemyScriptableObject)
        {
            Speed = enemyScriptableObject.Speed;
            Health = enemyScriptableObject.Health;
            m_LaunchForce = enemyScriptableObject.m_LaunchForce;
        }

        public void SetEnemyController(EnemyController _enemyController)
        {
            enemyController = _enemyController;
        }

        public float Speed { get; }
        public float Health { get; }
        public float m_LaunchForce { get; }
    }
}
