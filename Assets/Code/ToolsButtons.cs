using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ToolsButtons : MonoBehaviour {

    private static Color activeColor = new Color(49.0f/255.0f, 54.0f / 255.0f, 64.0f / 255.0f);
    private static Color deactiveColor = new Color(33.0f / 255.0f, 33.0f / 255.0f, 33.0f / 255.0f);
    private static Color deactiveHighlightColor = new Color(44.0f / 255.0f, 44.0f / 255.0f, 44.0f / 255.0f);


    private static ToolsButtons actualActiveButton;

    public bool active;

    public GameObject toolsView;

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(ActivateButton);

        if (active)
        {
            active = false;
            ActivateButton();
        }

    }

    private void ActivateButton()
    {
        if (!active)
        {
            active = true;
            if (actualActiveButton != null)
            {
                actualActiveButton.DeactivateButton();
            }
            actualActiveButton = this;
            toolsView.SetActive(true);

            Button btn = GetComponent<Button>();
            ColorBlock colors = btn.colors;
            colors.normalColor = activeColor;
            colors.highlightedColor = activeColor;
            btn.colors = colors;

        }
        

    }

    public void DeactivateButton()
    {
        active = false;
        toolsView.SetActive(false);

        Button btn = GetComponent<Button>();
        ColorBlock colors = btn.colors;
        colors.normalColor = deactiveColor;
        colors.highlightedColor = deactiveHighlightColor;
        btn.colors = colors;
    }
}
