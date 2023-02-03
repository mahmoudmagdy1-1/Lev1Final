using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotGame
{
    namespace EnemyDestroy
    {
        public class EnemyDestroy : MonoBehaviour
        {

            void Update()
            {
                Destroy(gameObject, 4);
            }
        }
    }
}