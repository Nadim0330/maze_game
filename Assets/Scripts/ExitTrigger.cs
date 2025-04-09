using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTrigger : MonoBehaviour
{
    public PlayerStats playerStats;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (playerStats != null && playerStats.hasKey)
            {
                Debug.Log("You Win!!!");
                playerStats.LevelUp();
                SceneManager.LoadScene("WinScene");
            }
            else
            {
                Debug.Log("Find the key first!");
            }
        }
    }

}
