using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Util : MonoBehaviour{

    [Header("Sprite to Change")]
    [SerializeField] public SpriteRenderer bodyPart;

    [Header("Sprite to Cycle Through")]
    [SerializeField] public List<Sprite> options = new List<Sprite>();

    private int currentOption = 0;

    //Una lista donde añadir cada parte del cuerpo
    public List<OutfitChanger> outfitChangers = new List<OutfitChanger>();
    
    enum AppearanceTrail{
        HAIR_MODEL,
        EYES_MODEL,
        NOSE_MODEL,
        GLASSES_MODEL,
        MOUTH_MODEL,
        SKIN_MODEL,
        BODY_MODEL
    }

    Dictionary<AppearanceTrail, int> chosenAppearance;

    //BOTONES
    public void NextOption(){
        currentOption++;
        if(currentOption >= options.Count){
            currentOption = 0; //Reset if cycled through entire list
        }
        bodyPart.sprite = options[currentOption];
        //ApplyModification(AppearanceTrail.bodyPart, options[currentOption]);
    }

    public void PreviousOption(){
        currentOption--;
        if(currentOption < 0){
            currentOption = options.Count - 1; //Reset if cycled through entire list
        }
        bodyPart.sprite = options[currentOption];
    }


    //Funcion para guardar el personaje con los cambios
    public void Submit(){
        //NO FUNCIONA SIN UNITY EDITOR PrefabUtility.SaveAsPrefabAsset(character, "Assets/Character.prefab");
        chosenAppearance = new Dictionary <AppearanceTrail, int>();

        //chosenAppearance.Add(AppearanceTrail.bodyPart, hairIndex);
        //chosenAppearance.Add(AppearanceTrail.BODY_MODEL, bodyIndex);
        
        SceneManager.LoadScene(0);
    }

    public void Randomize(){
        currentOption = Random.Range(0, options.Count);
        bodyPart.sprite = options[currentOption];
    }

    //Funcion para crear aleatoriedad
    public void RandomizeCharacter(){
        foreach (var changer in outfitChangers){
            changer.Randomize();
        }
    }
}

//Esto estaba en Util
/*
    public static void ResetTransform(this Transform _transform){
        _transform.localPosition = Vector3.zero;
        _transform.localEulerAngles = Vector3.zero;
        _transform.localScale = Vector3.one;
    }
*/

/*   TRANSFORMAR UN ENUM A LISTA
        enum Week
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        };
        private void button1_Click(object sender, EventArgs e)
        {
            List days = Enum.GetValues(typeof(Week)).Cast().ToList();
            foreach (Week day in days)
            {
                MessageBox.Show(day.ToString());
            }
        }
*/


/*CARGAR UN SPRITE
        //Load a Sprite (Assets/Resources/Sprites/sprite01.png)
        var sprite = Resources.Load<Sprite>("Sprites/sprite01");
*/




/* VISTO EN LA WEB
using UnityEngine;
using System.Collections.Generic;


 * 
 * This class will manage the creation of prefabs, including loading and saving them.
 * It will also store a list of all of the prefabs we've created.
 * 

public class ES3PrefabManager : MonoBehaviour 
{
	// The prefab we want to create.
	public GameObject prefab;
	// An automatically-generated unique identifier for this type of prefab.
	// We will append this to our keys when saving to identifiy different types
	// of prefab in the save file.
	public string id = System.Guid.NewGuid().ToString();
	
	// A List which we'll add the Transforms of our created prefabs to.
	private List<Transform> prefabInstances = new List<Transform>();

	
	 * This is called whenever the application is quit.
	 * This is where we will save our data.
	
	void OnApplicationQuit()
	{
		// Save the number of created prefabs there are.
		ES3.Save<int>(id+"count", prefabInstances.Count);
		// Save our Transforms.
		ES3.Save<List<Transform>>(id, prefabInstances);
	}

	// We also call OnApplicationPause, which is called when an app goes into the background. 
	void OnApplicationPause(bool isPaused)
	{
		if(isPaused)
			OnApplicationQuit();
	}

	
	 * This is called when the scene first loads.
	 * This is where we load our prefabs, if there are prefabs to load.
	
	void Start() 
	{
		int count = ES3.Load<int>(id + "count", 0);
		// If there are prefabs to load, load them.
		if(count > 0)
		{
			// For each prefab we want to load, instantiate a prefab.
			for(int i = 0; i < count; i++)
				InstantiatePrefab();
			// Load our List of Transforms into our prefab array.
			ES3.LoadInto<List<Transform>>(id, prefabInstances);
		}
	}

	
	 * 	Creates an instance of the prefab and adds it to the instance list.
	
	public GameObject InstantiatePrefab()
	{
		var go = Instantiate(prefab);
		prefabInstances.Add(go.transform);
		return go;
	}

	
	 * Instantiates the prefab at a random position and with a random rotation.
	
	public void CreateRandomPrefab()
	{
		var go = InstantiatePrefab();
		go.transform.position = Random.insideUnitSphere * 5;
		go.transform.rotation = Random.rotation;
	}

	
	 *  Deletes all prefab instances from the scene and from the save file.
	
	public void DeletePrefabs()
	{
		// Delete the keys relating to this prefab.
		ES3.DeleteKey(id);
		ES3.DeleteKey(id+"count");
		// Destroy each created prefab, and then clear the List.
		for(int i=0; i<prefabInstances.Count; i++)
			Destroy (prefabInstances[i].gameObject);
		prefabInstances.Clear();
	}
}
*/