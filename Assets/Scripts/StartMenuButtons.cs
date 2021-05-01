using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuButtons : MonoBehaviour
{
    public Animator transitionAnim;
    public GameObject panel;

    public void ProcedureScreen(){
        StartCoroutine(LoadScene1());
    }
    public void CharacterScreen(){
        StartCoroutine(LoadScene2());
    }
    public void LibraryScreen(){
        StartCoroutine(LoadScene3());
    }
    public void ExitApp(){
        Application.Quit();
    }

    IEnumerator LoadScene1(){
        panel.SetActive(true);
        transitionAnim.SetTrigger("outro");
        yield return new WaitForSeconds(1.05f);
        panel.SetActive(false);
        SceneManager.LoadScene("ProcedureSelector");
    }
    IEnumerator LoadScene2(){
        panel.SetActive(true);
        transitionAnim.SetTrigger("outro");
        yield return new WaitForSeconds(1.05f);
        panel.SetActive(false);
        SceneManager.LoadScene("CharacterCreation");
    }
    IEnumerator LoadScene3(){
        panel.SetActive(true);
        transitionAnim.SetTrigger("outro");
        yield return new WaitForSeconds(1.05f);
        panel.SetActive(false);
        SceneManager.LoadScene("Library");
    }
}