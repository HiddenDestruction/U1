using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class granpa : MonoBehaviour
{
public Rigidbody2D rb;
public float speed;
public float jumpForce;
public bool isGrounded = false; 
public Transform isGroundedChecker; 
public float checkGroundRadius; 
public LayerMask groundLayer;
public float fallMultiplier = 2.5f; 
public float lowJumpMultiplier = 2f;
public bool isFacingRight;

public int thrust = 4;
// [SerializeField] private Transform respawn;
// public Vector3 respawn = Vector3.zero;




void Start() { 
    rb = GetComponent<Rigidbody2D>(); 
    
    // respawn = GameObject.Find("Respawn").transform.position;
    // someScale = transform.localScale.x; // assuming this is facing right

}
void Update() 
{ 
    Move(); 
    Jump();
    BetterJump();
    CheckDirection();
} 
void Move() { 
    float x = Input.GetAxisRaw("Horizontal"); 
    float moveBy = x * speed; 
    rb.velocity = new Vector2(moveBy, rb.velocity.y); 
}
void Jump() { 
    if (Input.GetKeyDown(KeyCode.Space) && isGrounded) { 
        rb.velocity = new Vector2(rb.velocity.x, jumpForce); 
    } 
}
void BetterJump() {
    if (rb.velocity.y < 0) {
        rb.velocity += Vector2.up * Physics2D.gravity * (fallMultiplier - 1) * Time.deltaTime;
    } else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space)) {
        rb.velocity += Vector2.up * Physics2D.gravity * (lowJumpMultiplier - 1) * Time.deltaTime;
    }   
}

void CheckDirection()
{
    if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && isFacingRight == true) {
        isFacingRight = !isFacingRight;
        Flip();
    }

    if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A)) && isFacingRight == false) {
        isFacingRight = !isFacingRight;
        Flip();
    }
    
}

void Flip()
{
    // Switch the way the player is labelled as facing
    // isFacingRight = !isFacingRight;

    // Multiply the player's x local scale by -1
    Vector3 theScale = transform.localScale;
    theScale.x *= -1;
    transform.localScale = theScale;
}
void TestUp()
{
    if (Input.GetKey(KeyCode.I)) {
         rb.velocity = Vector3.up * thrust;
    }    
}


    //     void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.CompareTag("YouDieCollider"))
    //     {
    //         // Destroy(transform.parent.gameObject);
    //         transform.position = respawn;
    //     }
    // }

    //private void FixedUpdate()
    //{
    //    rb.velocity = new Vector2(driX, rb.velocity.y);
    //}




}
