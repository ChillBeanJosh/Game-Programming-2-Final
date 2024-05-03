using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
  
  public float health = 50f;
  public int kills;
  public bool hpBoost = false;


  void Update()
  {
     if (scoreManager.instance.score % 20 == 0 && scoreManager.instance.score > 0 )
    {
      hpBoost = true;

      if(hpBoost == true && scoreManager.instance.hit == true)
      {
        health += 50f;
        hpBoost = false;
      }
    }

  }


  public void TakeDamage (float amount)
  {
    health -= amount;
    if(health <= 0f)
    {
        Die();
    }
  }

  void Die()
  {
  
    Destroy(gameObject);
    kills ++;
    scoreManager.instance.AddPoint();
      
  }
}
