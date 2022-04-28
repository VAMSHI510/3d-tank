using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BattleTank
{
    [CreateAssetMenu(fileName = "Enemy Scriptable Object", menuName = "Scriptable Object")]
    public class EnemyScriptableObject : ScriptableObject
    {
        public string TankName;
        public float Speed;
        public float Health;
        public GameObject gameObject;
        public float m_LaunchForce = 10;
    }
}