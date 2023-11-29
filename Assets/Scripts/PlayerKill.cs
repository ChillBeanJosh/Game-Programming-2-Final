using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKill : MonoBehaviour
{
 private void OnCollisionStay(Collision other)
 {
    if(other.gameObject.name == "Player")
    {
        Debug.Log("You have been hit!");
    }
 }
}
