using UnityEngine;
using System.Collections;

public class ArrowController : MonoBehaviour {
    public int damage = 5;

    public float speed;
    public float fallBoundry = -20;
    public float Timer = 2;
    
    public Rigidbody2D rb;
	void Start ()
    {
        rb.velocity = new Vector2(speed * rb.velocity.x, speed * rb.velocity.y);
    }
	
	void Update ()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            Destroy(gameObject);
            Timer = 2;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            other.SendMessageUpwards("Damage", damage);
            Destroy(gameObject);

        }
        else if (other.tag != "Enemy")
        {
            Destroy(gameObject);
        }
        //Destroy(other.gameObject);
    }
}
