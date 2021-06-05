using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutfitCharacter : MonoBehaviour
{
    public static OutfitCharacter instance;

    public GameObject objectToFind;

    void Update(){
        /*if (instance != null){
            if (SceneManager.GetActiveScene().name == "CharacterCreation"){
                Destroy(gameObject);
            }
            Destroy(gameObject);
        }
        else{
            instance = this;
        }*/
        DontDestroyOnLoad(gameObject);

        objectToFind = GameObject.FindGameObjectWithTag("CharacterPS");

        OutfitDonePos(LoadCharacterPos(objectToFind.GetComponent<CharacterTransform>().CharacterPosX(), objectToFind.GetComponent<CharacterTransform>().CharacterPosY(), objectToFind.GetComponent<CharacterTransform>().CharacterPosZ()));
        OutfitDoneSize(LoadCharacterSize(objectToFind.GetComponent<CharacterTransform>().CharacterSizeX(), objectToFind.GetComponent<CharacterTransform>().CharacterSizeY(), objectToFind.GetComponent<CharacterTransform>().CharacterSizeZ()));
    }

    public Vector3 LoadCharacterPos(float posX, float posY, float posZ){

        Vector3 position;

        position = new Vector3(posX, posY, posZ);
        
        return position;
    }

    public Vector3 LoadCharacterSize(float sizeX, float sizeY, float sizeZ){

        Vector3 size;

        size.x = sizeX;
        size.y = sizeY;
        size.z = sizeZ;

        return size;        
    }

    public void OutfitDonePos (Vector3 position){

        transform.position = position;
    }
    public void OutfitDoneSize (Vector3 size){

        transform.localScale = size;
    }
}