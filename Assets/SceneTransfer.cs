using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneTransfer : MonoBehaviour{
  public int collectiblesCounter;

  void Start() {
    collectiblesCounter = 0;
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Player") && collectiblesCounter == 11) {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
  }
}
//}
