using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotGame
{
    namespace EnemyDestroy
    {
        public class EnemyDestroy : MonoBehaviour
        {
            private int Health = 100;
            [SerializeField] private GameObject EnemyDestEffect;
            [SerializeField] private GameObject EnemyDestroyPos;

            void Update()
            {
                Destroy(gameObject, 4);
            }
            private void OnCollisionEnter2D(Collision2D collision)
            {
                if (collision.gameObject.tag == "Bullet")
                {
                    Destroy(collision.gameObject);
                    Health -= 50;
                    if (Health <= 0) 
                    {
                    Instantiate(EnemyDestEffect, EnemyDestroyPos.transform.position, Quaternion.identity);
                    Destroy(gameObject);
                    }
                }
            }
        }
    }
}