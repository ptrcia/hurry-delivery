using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //mandatory

public class MainMenu : MonoBehaviour
{
  public void MenuGame()
  {
      SceneManager.LoadScene("0-menu");
  }
  public void PlayGame()
  {
      SceneManager.LoadScene("1-main");
  }
  public void QuitGame()
  {
      //Debug.Log("Quit");
      Application.Quit();
  }
}
