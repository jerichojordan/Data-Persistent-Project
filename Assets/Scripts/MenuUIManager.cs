using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIManager : MonoBehaviour
{
    [SerializeField] private Text inputName;
    public void StartButtonClick()
    {
        if (!inputName.text.Equals("")) HighscoreManager.Instance.playerName = inputName.text;
        else HighscoreManager.Instance.playerName = "Guest";
        SceneManager.LoadScene(1);
    }
    public void ExitButtonClick()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Exit();
#endif
    }
}
