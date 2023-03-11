using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    private Rigidbody2D rigid;
    private Animator anim;

    public float speed;

    public Transform rightCol;
    public Transform leftCol;
    public Transform headPoint;

    public LayerMask layer;
    public BoxCollider2D boxCollider2D;
    public CircleCollider2D circleCollider2D;
    
    private bool colliding;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = new Vector2(speed, rigid.velocity.y);

        colliding = Physics2D.Linecast(rightCol.position, leftCol.position, layer);

        if(colliding)
        {
            transform.localScale = new Vector2(transform.localScale.x * -1f, transform.localScale.y);            
            speed *= -1f;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            float height = col.contacts[0].point.y - headPoint.position.y;
            if(height > 0)
            {
                col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 6, ForceMode2D.Impulse);
                speed = 0;
                anim.SetTrigger("die");
                boxCollider2D.enabled = false;
                circleCollider2D.enabled = false;
                rigid.bodyType = RigidbodyType2D.Kinematic;
                Destroy(gameObject, 0.33f);
            }
        }
    }
}
