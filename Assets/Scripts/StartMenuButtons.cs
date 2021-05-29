using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuButtons : MonoBehaviour
{
    //public Animator transitionAnim;
    //public GameObject panel;

    public void ProcedureScreen(){
        SceneManager.LoadScene("ProcedureSelector");
    }
    public void CharacterScreen(){
        SceneManager.LoadScene("CharacterCreation");
    }
    public void LibraryScreen(){
        SceneManager.LoadScene("Library");
    }
    public void ExitApp(){
        Application.Quit();
    }

    /*IEnumerator LoadScene1(){
        //panel.SetActive(true);
        //transitionAnim.SetTrigger("outro");
        //yield return new WaitForSeconds(1.05f);
        //panel.SetActive(false);
        SceneManager.LoadScene("ProcedureSelector");
    }
    IEnumerator LoadScene2(){
        //panel.SetActive(true);
        //transitionAnim.SetTrigger("outro");
        //yield return new WaitForSeconds(1.05f);
        //panel.SetActive(false);
        SceneManager.LoadScene("CharacterCreation");
    }
    IEnumerator LoadScene3(){
        //panel.SetActive(true);
        //transitionAnim.SetTrigger("outro");
        //yield return new WaitForSeconds(1.05f);
        //panel.SetActive(false);
        SceneManager.LoadScene("Library");
    }*/
}