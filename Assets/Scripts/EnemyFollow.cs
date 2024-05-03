using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
   
   private Transform target;
   public float speed;
   public bool spdBoost;

   void Start()
   {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
   }

   void Update()
   {
    transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    transform.LookAt(target);
    

     if (scoreManager.instance.score % 25 == 0 && scoreManager.instance.score > 0 )
    {
      spdBoost = true;

      if(spdBoost == true && scoreManager.instance.hit == true)
      {
        speed += 5f;
        spdBoost= false;
      }
    }

   }
  
}
