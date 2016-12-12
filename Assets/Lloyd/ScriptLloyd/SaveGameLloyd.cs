using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class SaveGameLloyd : MonoBehaviour {
    public static string SAVEGAMEDATALOCATION= "Assets/Lloyd/Save_GameLloyd/";
    public static string SAVESLOT = "SAVESLOT.txt";

    
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
      if(Input.GetButtonDown("Horizontal"))
        {
            SaveSlot1();
        }

        

           
	}

    public void SaveSlot1()
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
    public void LoadSlot1()
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
