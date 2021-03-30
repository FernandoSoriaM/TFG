using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MusicPlayer : MonoBehaviour
{
    //private static MusicPlayer instance = null;//PARA QUE NO DEJE DE SONAR LA MUSICA

    public AudioSource AudioSource;

    private float musicVolume = 0.5f;
    //Create an array to store resolutions
    Resolution[] resolutions;
    public TMP_Dropdown resolutionDropdown;


    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        AudioSource.Play();
        //Get an array of all the resolutions we have at hand
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++){
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height){
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
        //DontDestroyOnLoad(this.gameObject);//
    }

    public void SetResolution (int resolutionIndex){
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = musicVolume;
    }

    public void updateVolume( float volume){
        musicVolume = volume;
    }
    public void SetFullScreen (bool isFullScreen){
        Screen.fullScreen = isFullScreen;
    }
}
