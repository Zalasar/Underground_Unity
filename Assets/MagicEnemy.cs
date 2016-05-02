using UnityEngine;
using System.Collections;

public class MagicEnemy : MonoBehaviour
{
    float currentHealth = 10;
    float maxHealth = 100;
    float damage = 10;

    public void MagicDmg()
    {

    }
    public void Shoot()
    {
        //RaycastHit2D hit = Physics2D.Raycast(X-firePointPosition, mousePosition - firePointPosition, range, whatToHit);
        //Debug.DrawLine(firePointPosition, (mousePosition - firePointPosition) * 100, Color.yellow);
        //if (hit.collider != null)
        //{
        //    Debug.DrawLine(firePointPosition, hit.point, Color.red);
        //}
        
        if (X - Player.X < 0)
        {
            if (Player.distance from enemy < 100)
            {
                //Shoot left
            }
        }
        if (X - Player.X > 0)
        {

        }
        
    }
    public void Awake()
    {
        currentHealth = maxHealth;
    }
    public void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void Damage(int damage)
    {
        currentHealth -= damage;
    }
}
