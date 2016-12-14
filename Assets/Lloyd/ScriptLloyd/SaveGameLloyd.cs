using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
/// <summary>
/// ONLY USE FOR HOUSE
/// SAve game that is in the main camera to save the location of the spawned house
/// </summary>
public class SaveGameLloyd : MonoBehaviour {
    /// <summary>
    /// switch between loading and saving
    /// </summary>
   public bool isLoading = false;
    /// <summary>
    /// reference to game object house
    /// </summary>
    public GameObject house1;
    /// <summary>
    /// reference to the class itself as a static object
    /// </summary>
    public static SaveGameLloyd saveGameLloyd;
    /// <summary>
    /// save structure location
    /// </summary>
    public static string SAVEGAMEDATALOCATION= "Assets/Lloyd/Save_GameLloyd/";
    /// <summary>
    /// save slot name
    /// </summary>
    public  static string SAVESLOT = "SAVESLOT.txt";
    /// <summary>
    /// List of building spawn points
    /// </summary>
    List<GameObject> savedSpawnedPoint;
    /// <summary>
    /// List of spawn point x position;
    /// </summary>
    List<float> spawnPosX;
    /// <summary>
    /// List of spawn point in y position
    /// </summary>
    List<float> spawnPosY;
    /// <summary>
    /// List of the point that is used
    /// </summary>
    List<int> savedUsedPoint;
    /// <summary>
    /// initiate the reference for savedSpawnedPoint and savedUsedPoint
    /// and spawnposX, spawnPosY
    /// and make reference to the game
    /// </summary>
    
	
	void Start () {
        saveGameLloyd = this;
        savedSpawnedPoint = GetComponent<SpawnHouse_Lloyd>().spawnPoint;
        savedUsedPoint = GetComponent<SpawnHouse_Lloyd>().getUsedLocation;
        spawnPosX = new List<float>();
        spawnPosY = new List<float>();
      

    }
	
	// Update is called once per frame
	void Update () {
        /*if (Input.GetButtonDown("SaveAndLoad")) 
        {
           
            if (isLoading) { LoadSlot1(); }
            else { SaveSlot1(); }
            
           
        }
       */




    }
    /// <summary>
    /// saving the game
    /// </summary>
    public void SaveSlot1()
    {
      
        FileStream fs = null;
        LoadingSave ls;
        try
        {
            if(savedUsedPoint.Count == 0)
            {
                ls = new LoadingSave();
            }
            else
            {
                addInPosition();
                ls = new LoadingSave(spawnPosX, spawnPosY, savedUsedPoint);
                print("Save " + spawnPosX[0] + " " + spawnPosY[0]);
            }
         
            fs = new FileStream(SAVEGAMEDATALOCATION + SAVESLOT, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
           bf.Serialize(fs, ls);
            fs.Close();
           
        }
        catch(Exception e)
        {
            print(e);
        }
        finally
        {
            if (fs != null) fs.Close();
            
        }   
    }

    /// <summary>
    /// loading gamedata
    /// </summary>
    public void LoadSlot1()
    {
       
        FileStream fs = null;
        try
        {
            
            fs = new FileStream(SAVEGAMEDATALOCATION + SAVESLOT, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            LoadingSave ls = (LoadingSave)bf.Deserialize(fs);
           
            spawnPosX = ls.spawnPosX;
            spawnPosY = ls.spawnPosY;
            savedUsedPoint = ls.loadingUsedPoint;
            GetComponent<SpawnHouse_Lloyd>().getUsedLocation = ls.loadingUsedPoint;
           recreatingBuilding(spawnPosX, spawnPosY, savedUsedPoint);
            print("Load " + spawnPosX[0] + " " + spawnPosY[0]);
            print("Load");
            fs.Close();
        }
        catch(Exception e)
        {
            print(e);
        }
        finally
        {
            if (fs != null) fs.Close();

        }
    }
    /// <summary>
    /// bspawning building to the saved location
    /// </summary>
    /// <param name="spawnPoint"></param>
    /// <param name="usedPoint"></param>

    public void recreatingBuilding(List<float> posX, List<float>posY, List<int> usedPoint)
    {
        print(usedPoint.Count);
        for (int i=0; i<(usedPoint.Count);i++)
        {
            print("recreatingBuilding");
            float x =posX[i];
            float y =posY[i];
            float z = 1;
            Vector3 location = new Vector3(x, y, z);
            Instantiate(house1, location, Quaternion.identity);
        }
    }
    /// <summary>
    /// convert gameObject position into a list
    /// </summary>
    void addInPosition()
    {
        List<float> PosX = new List<float>();
        List<float> PosY = new List<float>();
        for (int i = 0; i < (savedUsedPoint.Count); i++)
        {
            PosX.Add(savedSpawnedPoint[savedUsedPoint[i]].transform.position.x);
            PosY.Add(savedSpawnedPoint[savedUsedPoint[i]].transform.position.y);
        }
        spawnPosX = PosX;
        spawnPosY = PosY;


    }

}

[Serializable]
class LoadingSave
{/// <summary>
/// saving the game into data
/// </summary>
   public List<GameObject> loadingSpawnLocation;
    /// <summary>
    /// saving spawn location in x direction
    /// </summary>
    public List<float> spawnPosX;
    /// <summary>
    /// saving spawn loaction in y direction
    /// </summary>
    public List<float> spawnPosY;
    /// <summary>
    /// loading number of used point;
    /// </summary>
   public List<int> loadingUsedPoint;
    /// <summary>
    /// place holder
    /// </summary>
    public string cheese;
    /// <summary>
    /// constructor for saving the game
    /// </summary>
    /// <param name="posX">list of x direction that is saved</param>
    /// <param name="posY">list of y direction that is saved</param>
    /// <param name="usedPoint">used point that is saved</param>
    public LoadingSave(List<float> posX, List<float> posY, List<int> usedPoint)
    {
        spawnPosX = posX;
        spawnPosY = posY;
        loadingUsedPoint = usedPoint;
        }
    /// <summary>
    /// testing and default setting
    /// </summary>
    /// <param name="lol">testing string</param>
    public LoadingSave (string lol)
    {
        cheese = lol;
    }
    /// <summary>
    /// default saving if used point length is 0
    /// </summary>
    public LoadingSave()
    {

    }

}
