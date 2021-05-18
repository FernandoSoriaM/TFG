using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//_using UnityEditor;

public class OutfitMaster : MonoBehaviour
{

    //public List<OutfitChanger> outfitSaver = new List<OutfitChanger>();

    //_Un objeto para almacenar el prefab
    //_public GameObject character;

    //Una lista donde añadir cada parte del cuerpo
    public List<OutfitChanger> outfitChangers = new List<OutfitChanger>();

    //Funcion para crear aleatoriedad
    public void RandomizeCharacter(){
        foreach (OutfitChanger changer in outfitChangers){
            changer.Randomize();
        }
    }

    //Funcion para guardar el personaje con los cambios
    public void Submit(){
        //_PrefabUtility.SaveAsPrefabAsset(character, "Assets/Character.prefab");
        /*foreach (OutfitChanger saver in outfitSaver){
            saver.
        }*/
        SceneManager.LoadScene(0);
    }
}