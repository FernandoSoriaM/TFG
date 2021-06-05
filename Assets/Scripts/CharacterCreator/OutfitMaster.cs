using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEditor;

public class OutfitMaster : MonoBehaviour
{
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
        //NO FUNCIONA SIN UNITY EDITOR PrefabUtility.SaveAsPrefabAsset(character, "Assets/Character.prefab");
        
        SceneManager.LoadScene(0);
    }
}