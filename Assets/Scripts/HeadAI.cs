using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadAI : MonoBehaviour
{
    [SerializeField] Transform[] Positions; 
    [SerializeField] float ObjectSpeed;
    int NextPosIndex;
    Transform NextPos;
    public Rigidbody2D rb;
    public int thrust = 40;

    // Start is called before the first frame update
    void Start()
    {
        NextPos = Positions[0];
        rb = GetComponent<Rigidbody2D>(); 
        Flip();
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject();        
    }

    void MoveGameObject()
    {
        if (transform.position == NextPos.position)
        {
            print("test");
            Flip();
            NextPosIndex++;
            if (NextPosIndex >= Positions.LongLength)
            {
                NextPosIndex = 0;

            }
            NextPos = Positions[NextPosIndex];
        }
        else 
        {
            transform.position = Vector3.MoveTowards(transform.position, NextPos.position, ObjectSpeed * Time.deltaTime);

        }
    }
    void Flip()
{
    Vector3 theScale = transform.localScale;
    theScale.x *= -1;
    transform.localScale = theScale;
}

    void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Bullet"))
    {
        print("ababa333");
        rb.velocity = Vector3.up * thrust;
    }
}




}
