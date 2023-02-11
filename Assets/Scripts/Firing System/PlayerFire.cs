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
            public GameObject BulletHead;
            public GameObject BulletShoes;

            public GameObject FireEffect;
            public Transform firePoint;
            public Transform firePointHead;
            public Transform firePointShoes;
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