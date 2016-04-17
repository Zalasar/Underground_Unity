using UnityEngine;
using System.Collections;

public class ArrowController : MonoBehaviour {
    public int damage = 5;

    public float speed;
    public float fallBoundry = -20;

    public Rigidbody2D rb;
	void Start ()
    {
        rb.velocity = new Vector2(speed * rb.velocity.x, speed * rb.velocity.y);
    }
	
	void Update ()
    {

        
        if (rb.position.y <= fallBoundry)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        other.SendMessageUpwards("Damage", damage);
        Destroy(gameObject);
        //Destroy(other.gameObject);
    }
}
