using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUiHandler : MonoBehaviour
{
    public static MenuUiHandler instance;

    public Text HIGHSCORETXT;
    private string txt;
    void Start()
    {
        HIGHSCORETXT.text = "Best Score: " + $"{ ReferenceForMain.inostance.HighestScoreString}" + $" {ReferenceForMain.inostance.HighestScoreName}";
    }

    

    public void returnToMenuExit()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        ReferenceForMain.inostance.UsernameSubmit();
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();

    #else
            Application.Quit();

    #endif
    }
}
