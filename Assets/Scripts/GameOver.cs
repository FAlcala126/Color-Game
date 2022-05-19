using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
  public GameObject GameOverMenu;
  public Button Respawn, Quit;
  public GameObject player;
  public GameObject respawnPoint;
  public Transform playerR;
  public Transform respawn;

  void OnTriggerEnter(Collider other)
     {
        player.SetActive(false);
         GameOverMenu.SetActive(true);
     }

  public void RespawnClick()
  {
    GameOverMenu.SetActive(false);
    playerR.transform.position = respawn.transform.position;
    player.SetActive(true);
  }

  public void QuitClick()
  {
    SceneManager.LoadScene("START");
  }

}
