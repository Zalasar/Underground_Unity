using UnityEngine;
using System.Collections;

public class ArrowController : MonoBehaviour {
    public int damage = 5;

    public float speed;

    public Rigidbody2D rb;
	void Start () {
	
	}
	
	void Update ()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        col.SendMessageUpwards("Damage", damage);
        Destroy(gameObject);
    }
}
