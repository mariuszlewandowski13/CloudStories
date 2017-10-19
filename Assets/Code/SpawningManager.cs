using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningManager : MonoBehaviour {

    public GameObject SpawnObject(GameObject objToSpawn, Vector3 position, Quaternion rotation = new Quaternion())
    {
       return  Instantiate(objToSpawn, position, rotation);
    }
}
