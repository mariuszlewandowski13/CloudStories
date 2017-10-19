using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour {

    private string message;

    public void SaveObject(string objectName, int number, Vector3 pos)
    {
        WWWForm form = new WWWForm();
        form.AddField("objectName", objectName);
        form.AddField("objectNumber", number);
        form.AddField("posX", pos.x.ToString());
        form.AddField("posY", pos.y.ToString());
        form.AddField("posZ", pos.z.ToString());
        WWW w = new WWW(ApplicationData.serverScriptsPath + "AddObject.php", form);
        StartCoroutine(request(w));
    }

    public void SaveLayout(int number)
    {
        WWWForm form = new WWWForm();
        form.AddField("layoutNumber", number);
        WWW w = new WWW(ApplicationData.serverScriptsPath + "ChangeLayout.php", form);
        StartCoroutine(request(w));
    }

    IEnumerator request(WWW w)
    {
        yield return w;
        if (w.error == null)
        {
            message = w.text;
        }
        else
        {
            message = "ERROR: " + w.error + "\n";
        }
        Debug.Log(message);
    }
}
