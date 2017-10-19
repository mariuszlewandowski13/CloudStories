using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningManager : MonoBehaviour {

    private GameObject layoutObject;
    private GameObject enviromentPlane;

    private void Start()
    {
        enviromentPlane = transform.Find("Enviroment plane").gameObject;
        layoutObject = enviromentPlane.transform.Find("Layout").gameObject;
    }

    public GameObject SpawnObject(GameObject objToSpawn, Vector3 position, int number,  Quaternion rotation = new Quaternion())
    {
        GetComponent<DatabaseManager>().SaveObject("3DObj", number, position);
       return  Instantiate(objToSpawn, position, rotation);
    }

    public void LoadLayout(GameObject newLayout, Vector3 pos, int layoutNumber, Quaternion rotation = new Quaternion())
    {
        if (layoutObject.transform.childCount > 0)
        {
            ClearLayout();
        }

        GameObject newLay = Instantiate(newLayout, pos, rotation);
        newLay.transform.parent = layoutObject.transform;

        GetComponent<DatabaseManager>().SaveLayout(layoutNumber);
    }

    private void ClearLayout(bool save = false)
    {
        if (layoutObject != null)
        {
            foreach (Transform child in layoutObject.transform)
            {
                Destroy(child.gameObject);
            }
        }
        if (save)
        {
            GetComponent<DatabaseManager>().SaveLayout(0);
        }
        
    }
}
