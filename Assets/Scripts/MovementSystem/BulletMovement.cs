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

            void Update()
            {
                BulletMove();
            }
            private void BulletMove()
            {
                transform.position += Move * Time.deltaTime;
            }
        }
    }
}
