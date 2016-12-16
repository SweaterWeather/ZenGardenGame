using UnityEngine;
using System.Collections;
/// <summary>
/// this class use to spawn map
/// </summary>
public class SpawningMap_Lloyd : MonoBehaviour {
    /// <summary>
    /// A reference to the save game script.
    /// </summary>
    public SavePlant_Lloyd save;
    /// <summary>
    /// this array is reference to the world map
    /// </summary>
    int[,] gridMap;
    /// <summary>
    /// space between tile
    /// </summary>
    public float tileSpacing = 1f;

    /// <summary>
    /// grass sprite
    /// </summary>
    public GameObject grass;
    /// <summary>
    /// dirt sprite
    /// </summary>
    public GameObject dirt;
    /// <summary>
    /// stone sprite
    /// </summary>
    public GameObject stone;
    /// <summary>
    /// get function create map to make the map appear
    /// </summary>
	void Start () {
        createMap();
        if(save)save.loadPlant();
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
                if (gridMap[y, x] == 2)
                {
                    Instantiate(dirt, makeTileLocation(x, y), Quaternion.identity);
                }
                if (gridMap[y, x] == 3)
                {
                    Instantiate(stone, makeTileLocation(x, y), Quaternion.identity);
                }
            }
        }
        
    }
    /// <summary>
    /// placing the time
    /// </summary>
    /// <param name="x">x direction of the tile</param>
    /// <param name="y">y direction of the tile</param>
    /// <returns></returns>
    Vector3 makeTileLocation(int x, int y)
    {
        float pointX = x *tileSpacing;
        float pointY = -y * tileSpacing;
        float pointZ = 0;
        Vector3 direction=new Vector3(pointX, pointY,pointZ);
        return direction;
    }
}
