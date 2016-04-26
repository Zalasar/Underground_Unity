﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    float currentHealth = 10;
    float maxHealth = 100;
    float damage = 10;
//	[System.Serializable]
 //   public class EnemyStats
 //   {
 //       public int Health = 100;
 //   }
 //   public EnemyStats stats = new EnemyStats();

 //   public void DamageEnemy (int Damage)
 //   {
 //       stats.Health -= Damage;
 //       if(stats.Health <= 0)
 //       {
 //           GameMaster.KillEnemy(this);
 //       }
 //   }

    void OnTriggerEnter2D(Collider2D other)
    {
        other.SendMessageUpwards("Damage", damage);
        Debug.Log("Hit");
        //Destroy(gameObject);
        //Destroy(other.gameObject);
    }
 public void Awake()
    {
        currentHealth = maxHealth;
    }
 public void Update()
    {
        if (currentHealth <=0)
        {
            Destroy(gameObject);
        }
    }
 public void Damage(int damage)
    {
        currentHealth -= damage;
    }
}
