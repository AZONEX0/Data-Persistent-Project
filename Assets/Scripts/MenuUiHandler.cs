using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUiHandler : MonoBehaviour
{
    public static MenuUiHandler instance;

    //public TextMeshProUGUI USERNAME;
    
    //public TextMeshProUGUI BestScoreNme;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //DontDestroyOnLoad(gameObject);       
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
