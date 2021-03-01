using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProcedureSelection : MonoBehaviour
{
    public void AuscultationScreen(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void TemperatureScreen(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void XRayScreen(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void EscayolaScreen(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }
    public void SutureScreen(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }
    public void GoBack(){
        SceneManager.LoadScene("MainMenu");
    }
}