using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace robotGame
{
    namespace bulletMovement
    {
        public class BulletMovement : MonoBehaviour
        {
            public Vector3 Move;
            public Rigidbody2D rb;
            void Start()
            {
                rb = GetComponent<Rigidbody2D>();
            }
            void Update()
            {
                BulletMove();
            }
            private void BulletMove()
            {
                rb.velocity = transform.right * 20f;
                //transform.position += Move * Time.deltaTime;
            }
        }
    }
}
