using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProcedureSelection : MonoBehaviour
{
    public Animator transitionAnim;
    public GameObject panel;

    public void AuscultationScreen(){
        SceneManager.LoadScene("AuscultationMinigame");
    }
    public void TemperatureScreen(){
        SceneManager.LoadScene("TemperatureMinigame");
    }
    public void XRayScreen(){
        SceneManager.LoadScene("XRayMinigame");
    }
    public void EscayolaScreen(){
        SceneManager.LoadScene("EscayolaMinigame");
    }
    public void SutureScreen(){
        SceneManager.LoadScene("SutureMinigame");
    }
    public void GoBack(){
        SceneManager.LoadScene("MainMenu");
    }
    /*
    IEnumerator LoadScene4(){
        panel.SetActive(true);
        transitionAnim.SetTrigger("outro");
        yield return new WaitForSeconds(1.05f);
        panel.SetActive(false);
        SceneManager.LoadScene("AuscultationMinigame");
    }
    IEnumerator LoadScene5(){
        panel.SetActive(true);
        transitionAnim.SetTrigger("outro");
        yield return new WaitForSeconds(1.05f);
        panel.SetActive(false);
        SceneManager.LoadScene("TemperatureMinigame");
    }
    IEnumerator LoadScene6(){
        panel.SetActive(true);
        transitionAnim.SetTrigger("outro");
        yield return new WaitForSeconds(1.05f);
        panel.SetActive(false);
        SceneManager.LoadScene("XRayMinigame");
    }
    IEnumerator LoadScene7(){
        panel.SetActive(true);
        transitionAnim.SetTrigger("outro");
        yield return new WaitForSeconds(1.05f);
        panel.SetActive(false);
        SceneManager.LoadScene("EscayolaMinigame");
    }
    IEnumerator LoadScene8(){
        panel.SetActive(true);
        transitionAnim.SetTrigger("outro");
        yield return new WaitForSeconds(1.05f);
        panel.SetActive(false);
        SceneManager.LoadScene("SutureMinigame");
    }
    IEnumerator LoadScene9(){
        panel.SetActive(true);
        transitionAnim.SetTrigger("outro");
        yield return new WaitForSeconds(1.05f);
        panel.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }*/
}