using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RobotGame
{
    namespace EnemyMovement
    {
        public class PlayerMovement : MonoBehaviour
        {
            float xValue;
            int coinScore;
            Rigidbody2D rb;
            bool isFacingRight = true;
            [SerializeField] private float jumpForce;
            [SerializeField] private bool ableToJump;
            [SerializeField] private float moveSpeed;
            private void OnCollisionEnter2D(Collision2D collision)
            {
                if (collision.gameObject.tag == "Ground") { ableToJump = true; }
                if (collision.gameObject.tag == "Coin") { coinScore++; Debug.Log(coinScore); }
                
                    
            }
            private void Start()
            {
                rb = GetComponent<Rigidbody2D>();
            }
            void Update()
            {
                MovePlayer();
                Jump();

                if (xValue > 0 && !isFacingRight) Flip();
                else if (xValue < 0 && isFacingRight) Flip();
            }
            void MovePlayer()
            {
               xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
               transform.position += new Vector3 (xValue, 0, 0);
                //rb.velocity = new Vector2(xValue, 0);
            }
            void Jump()
            {
                if (Input.GetKeyDown(KeyCode.Space) && ableToJump == true)
                {
                    ableToJump = false;
                    rb.AddForce(transform.up * jumpForce);
                }
            }
            void Flip()
            {
                isFacingRight = !isFacingRight;
                transform.Rotate(0, 180f, 0);
            }
            
        }
    }
}
