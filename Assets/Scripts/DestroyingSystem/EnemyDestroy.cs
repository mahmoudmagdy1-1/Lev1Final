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
            private void OnCollisionEnter2D(Collision2D collision)
            {
                if(collision.gameObject.tag == "Bullet")
                {
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                }
            }
        }
    }
}