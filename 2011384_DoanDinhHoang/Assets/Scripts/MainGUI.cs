using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainGUI : MonoBehaviour
{
    public void NewGame()
    {

        SceneManager.LoadScene(1);
        Time.timeScale = 1;

    }
}
