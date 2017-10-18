using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class DesignBtn : MonoBehaviour {

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(LoadSecondScene);
    }

    void LoadSecondScene()
    {
        SceneManager.LoadScene(ApplicationData.designScene);
    }
}
