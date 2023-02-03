using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotGame{
    namespace Enemies {
    public class Enemies : MonoBehaviour
    {
            public GameObject Enemy1;
            public Transform EnemyPosition;
            private void Update()
            {
                Enemy();
            }
            private void Enemy()
        {
                if (Input.GetMouseButtonDown(1))
                {
                    Instantiate(Enemy1, EnemyPosition.position, Quaternion.identity);
                }
        }
    }
    }
}
