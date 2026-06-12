using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUiHandler : MonoBehaviour
{
    public static MenuUiHandler instance;

    public TMP_InputField USERNAME;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

   public void usernameSubmit()
    {
        string username = USERNAME.text;
    }

    public void returnToMenuExit()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        //MainManager.Instance.gameStart();
        usernameSubmit();
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
