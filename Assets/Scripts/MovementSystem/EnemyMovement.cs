using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotGame
{
    namespace EnemyMovement
    {
        public class EnemyMovement : MonoBehaviour
        {
            [SerializeField] private float moveSpeed = 5f;
            public Rigidbody2D rb;
            private void Start()
            {
                rb = GetComponent<Rigidbody2D>();
            }
            void Update()
            {
                rb.AddForce(Vector2.left * moveSpeed);
                //transform.position += Move * Time.deltaTime;
            }


        }
    }
}
