using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace robotGame
{
    namespace firingSystem
    { 

    public class PlayerFire : MonoBehaviour
    {
            public GameObject Bullet;
            public Transform firePoint;
            public Animator animator;
            private void Update()
            {
                Fire();
            }
            private void Fire()
            {
                if (Input.GetMouseButtonDown(0))
                {
                    animator.SetTrigger("fire");
                    Instantiate(Bullet,firePoint.position,Quaternion.identity);
                }
            }
           
    }
    }

}