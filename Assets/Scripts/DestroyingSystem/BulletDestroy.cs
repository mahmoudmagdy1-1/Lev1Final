using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace robotGame
{
    namespace bulletDestroy { 
    
        public class BulletDestroy : MonoBehaviour
        {
        [SerializeField] float destroyTime;
        void Start()
            {
                Destroy(gameObject, destroyTime);
            }

        }
    }
}
