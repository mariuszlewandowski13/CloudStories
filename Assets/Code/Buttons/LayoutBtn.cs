using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class LayoutBtn : MonoBehaviour {

    public GameObject workingEnviroment;
    public GameObject layoutToLoad;
    public Vector3 position;

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(Loadlayout);
    }

    void Loadlayout()
    {
        workingEnviroment.GetComponent<SpawningManager>().LoadLayout(layoutToLoad, position);
    }
}
