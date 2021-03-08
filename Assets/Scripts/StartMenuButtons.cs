using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuButtons : MonoBehaviour
{
    public void ProcedureScreen(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void CharacterScreen(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void LibraryScreen(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }
    public void ExitApp(){
        Application.Quit();
    }
}
