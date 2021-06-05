using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTransform : MonoBehaviour
{
    public float posX;
    public float posY;
    public float posZ;

    public float sizeX;
    public float sizeY;
    public float sizeZ;
   
    public float CharacterPosX(){
        return posX;
    }

    public float CharacterPosY(){
        return posY;
    }

    public float CharacterPosZ(){
        return posZ;
    }

    public float CharacterSizeX(){
        return sizeX;
    }

    public float CharacterSizeY(){
        return sizeY;
    }
    public float CharacterSizeZ(){
        return sizeZ;
    }
}