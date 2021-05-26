using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customization : MonoBehaviour
{
    enum AppearanceDetail{ //x
        HAIR_MODEL,
        EYES_MODEL,
        NOSE_MODEL,
        GLASSES_MODEL,
        MOUTH_MODEL,
        SKIN_MODEL,
        BODY_MODEL
    }
    
    [SerializeField] private GameObject[] bodyModels; //En bueno son options?

    [SerializeField] private Transform bodyAnchor;

    [SerializeField] private GameObject[] skinModels;

    GameObject activeBody;

    GameObject activeSkin;

    Dictionary<AppearanceDetail, int> chosenAppearance; //x

    //Buttons
    int bodyIndex = 0;

    public void BodyModelUp(){
        if(bodyIndex < bodyModels.Length -1){
            bodyIndex++;
        }
        else{
            bodyIndex = 0;
        }
        ApplyModification(AppearanceDetail.BODY_MODEL, bodyIndex);
    }

    public void BodyModelDown(){
        if(bodyIndex > 0){
            bodyIndex--;
        }
        else{
            bodyIndex = bodyModels.Length -1;
        }
        ApplyModification(AppearanceDetail.BODY_MODEL, bodyIndex);
    }

    void ApplyModification(AppearanceDetail detail, int id){
        switch(detail){
            case AppearanceDetail.BODY_MODEL:
                if(activeBody != null){
                    GameObject.Destroy(activeBody);
                }
                activeBody = GameObject.Instantiate(bodyModels[id]);
                activeBody.transform.SetParent(bodyAnchor);
                //activeBody.transform.ResetTransform();
                break;
            case AppearanceDetail.SKIN_MODEL:
                if(activeSkin != null){
                    ;
                }
                break;
        }
    }

    public void SaveAppearance(){
        chosenAppearance = new Dictionary <AppearanceDetail, int>();

        //chosenAppearance.Add(AppearanceDetail.HAIR_MODEL, hairIndex);
        chosenAppearance.Add(AppearanceDetail.BODY_MODEL, bodyIndex);
    } 
}