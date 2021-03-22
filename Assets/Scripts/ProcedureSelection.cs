using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProcedureSelection : MonoBehaviour
{
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
}