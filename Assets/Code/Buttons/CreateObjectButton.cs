using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class CreateObjectButton : MonoBehaviour {

    public GameObject objectToCreate;
    public Vector3 position;
    public GameObject workingEnviroment;

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(CreateObject);
    }

    void CreateObject()
    {
        workingEnviroment.GetComponent<SpawningManager>().SpawnObject(objectToCreate, position);
    }
}
