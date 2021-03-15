using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutfitMaster : MonoBehaviour
{
    //Un objeto para almacenar el prefab
    public GameObject character;
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
        PrefabUtility.SaveAsPrefabAsset(character, "Assets/Character.prefab");
        SceneManager.LoadScene(0);
    }
}
