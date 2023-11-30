using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerKill : MonoBehaviour
{
 private void OnCollisionStay(Collision other)
 {
    if(other.gameObject.name == "Player")
    {
        Debug.Log("You have been hit!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
 }
}
