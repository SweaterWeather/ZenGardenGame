using UnityEngine;
using System.Collections;
/// <summary>
/// this class use to spawn map
/// </summary>
public class SpawningMap_Lloyd : MonoBehaviour {
    /// <summary>
    /// this array is reference to the world map
    /// </summary>
    int[,] gridMap;
    /// <summary>
    /// space between tile
    /// </summary>
    public float tileSpacing = 1f;


    public GameObject grass;
	void Start () {
        createMap();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    /// <summary>
    /// create the map of the game
    /// </summary>
    void createMap()
    {
        gridMap = ArrayMap_Lloyd.map;
       
        
        for (int y=0; y< (gridMap.GetLength(0)); y++)
        {
            for (int x =0; x< (gridMap.GetLength(1)); x++)
            {
                if (gridMap[y, x] == 1)
                {
                    Instantiate(grass, makeTileLocation(x, y), Quaternion.identity);
                }
            }
        }
        
    }

    Vector3 makeTileLocation(int x, int y)
    {
        float pointX = x *tileSpacing;
        float pointY = -y * tileSpacing;
        float pointZ = 0;
        Vector3 direction=new Vector3(pointX, pointY,pointZ);
        return direction;
    }
}
