using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public GameObject myPlayer;
    public float maxDistDelta = 0.1f;

   private void LateUpdate()
   {

    Vector3 playerPos = myPlayer.transform.position;
    Vector3 targetPos = Vector3.Lerp(playerPos, this.transform.position, .5f);
    transform.position = Vector3.MoveTowards(transform.position, playerPos, maxDistDelta * Time.deltaTime);
   }
}
