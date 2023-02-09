using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RobotGame
{
    namespace FireEffectDestroy
    {
        public class FireEffectDestroy : MonoBehaviour
        {
            private void Update()
            {
                Destroy(gameObject, 0.5f);

            }
        }
    }
}
