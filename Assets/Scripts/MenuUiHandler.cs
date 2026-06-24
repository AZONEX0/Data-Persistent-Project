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
    //public TextMeshProUGUI USERNAME;

    //public TextMeshProUGUI BestScoreNme;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //MainManager.Instance.LoadHighScoreN();
        //MainManager.Instance.BestScoreNamee.text = MainManager.Instance.BestScoreSave;
        //DontDestroyOnLoad(gameObject
        HIGHSCORETXT.text = $" {ReferenceForMain.inostance.HighestScoreString}" + $" {ReferenceForMain.inostance.usaarname}";
    }

    

    public void returnToMenuExit()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        ReferenceForMain.inostance.UsernameSubmit();
        //ReferenceForMain.inostance.usernametest();
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
