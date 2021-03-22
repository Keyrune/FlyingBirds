using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton;
    private static int _nextLevelIndex;

    void Start()
    {
        m_YourFirstButton.onClick.AddListener(() => ButtonClicked(1));
        m_YourSecondButton.onClick.AddListener(() => ButtonClicked(2));
        m_YourThirdButton.onClick.AddListener(() => ButtonClicked(3));
    }

    void ButtonClicked(int buttonNo)
    {
        //Output this to console when the Button is clicked
        Debug.Log("Button clicked = " + buttonNo);
        string levelName = "Level" + buttonNo;
        _nextLevelIndex = 3;
        SceneManager.LoadScene(levelName);
    }
}