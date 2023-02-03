using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace robotGame
{
    namespace bulletDestroy
    {
        public class SpawnEnemy : MonoBehaviour
        {
            [SerializeField] private GameObject Enemy;
            [SerializeField] private Transform enemySpawnPoint;

            void Start()
            {
               InvokeRepeating("Spawning",3,2);
            }
            private void Spawning()
            {
                Instantiate(Enemy, enemySpawnPoint.position, Quaternion.identity);
            }
        }
    }
}
