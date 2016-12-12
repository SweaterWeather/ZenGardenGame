using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
/// <summary>
/// SAve game that is in the main camera to save the location of the spawned house
/// </summary>
public class SaveGameLloyd : MonoBehaviour {
    /// <summary>
    /// save structure location
    /// </summary>
    public static string SAVEGAMEDATALOCATION= "Assets/Lloyd/Save_GameLloyd/";
    /// <summary>
    /// save slot name
    /// </summary>
    public static string SAVESLOT = "SAVESLOT.txt";
    /// <summary>
    /// List of building spawn points
    /// </summary>
    List<GameObject> savedSpawnedPoint;
    /// <summary>
    /// List of the point that is used
    /// </summary>
    List<int> savedUsedPoint;
    
	
	void Start () {
        savedSpawnedPoint = GetComponent<SpawnHouse_Lloyd>().spawnPoint;
	}
	
	// Update is called once per frame
	void Update () {
      if(Input.GetButtonDown("Horizontal"))
        {
            SaveSlot1();
        }

        

           
	}

    public static void SaveSlot1()
    {
        LoadingSave ls = new LoadingSave("papaJohn");
        
        FileStream fs = null;
        try
        {
            fs = new FileStream(SAVEGAMEDATALOCATION+SAVESLOT, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ls);
            fs.Close();
            print("Save");
        }
        catch(Exception e)
        {

        }
        finally
        {
            if (fs != null) fs.Close();
            print("Save");
        }   
    }
    public static void LoadSlot1()
    {
        FileStream fs = null;
        try
        { BinaryFormatter bf = new BinaryFormatter();
            fs = new FileStream(SAVEGAMEDATALOCATION + SAVESLOT, FileMode.Open);
            LoadingSave ls = (LoadingSave)bf.Deserialize(fs);
            print(ls.cheese);
            fs.Close();
        }
        catch(Exception e)
        {

        }
        finally
        {
            fs.Close();
        }
    }




}

[Serializable]
class LoadingSave
{
    List<GameObject> loadingSpawnLocation;
    List<int> loadingUsedPoint;
    public string cheese;
   public LoadingSave(string lol)
    {
        cheese = lol;
        }

}
