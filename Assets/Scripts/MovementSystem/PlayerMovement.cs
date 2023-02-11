using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotGame
{
    namespace EnemyMovement
    {
        public class PlayerMovement : MonoBehaviour
        {
            private float xValue;
            [SerializeField] private float jumpForce;
            [SerializeField] private bool ableToJump;
            [SerializeField] private float moveSpeed;

            // Update is called once per frame
            void Update()
            {
                MovePlayer();
                Jump();
            }
            void MovePlayer()
            {
               xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
               transform.Translate(xValue, 0, 0);
            }
            void Jump()
            {
                if (Input.GetKeyDown(KeyCode.Space) && ableToJump == true)
                {
                    ableToJump = false;
                    transform.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce);
                }
            }
            private void OnCollisionEnter2D(Collision2D collision)
            {
                if(collision.gameObject.tag == "Ground") 
                    ableToJump = true;
            }
        }
    }
}
