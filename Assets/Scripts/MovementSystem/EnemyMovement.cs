using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotGame
{
    namespace EnemyMovement
    {
        public class EnemyMovement : MonoBehaviour
        {
            [SerializeField] private Vector3 Move;
            void Update()
            {
                transform.position += Move * Time.deltaTime;
            }


        }
    }
}
