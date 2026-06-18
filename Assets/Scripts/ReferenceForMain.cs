using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReferenceForMain : MonoBehaviour
{
    public string usaarname;
    public TMP_InputField USERNAME;

    public string highScore;

    public int liveScore;

    public static ReferenceForMain inostance;

    private void Awake()
    {
        //USERNAME = TMP_InputField.FindAnyObjectByType<TMP_InputField>();
        if (inostance != null)
        {
            //USERNAME = ReferenceForMain.inostance.USERNAME;
            //USERNAME = TMP_InputField.FindAnyObjectByType<TMP_InputField>(); does work

            //inostance.usaarname = this.usaarname; doesnt work
            Destroy(gameObject);
            return;
            //}
            //else if (Instance = null)
            //{
            //    Instantiate(gameObject);
        }
        //else if (inostance = null)
        //{
        //    Instantiate(inostance);
        //}
        inostance = this;
        DontDestroyOnLoad(gameObject);
        //FindAllReferences();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //GameObject USERNAME = GameObject.FindWithTag("Nameinput");
        //USERNAME = TMP_InputField.FindAnyObjectByType<TMP_InputField>();
    }


    //private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    //{
    //    if(SceneManager.GetActiveScene().buildIndex == 0)
    //    {

    //    }
    //}

    public string UsernameSubmit()
    {
        USERNAME = TMP_InputField.FindAnyObjectByType<TMP_InputField>();
        ReferenceForMain.inostance.usaarname = USERNAME.text;
        string username = USERNAME.text;
        usaarname = username;
        Debug.Log(USERNAME);
        return usaarname;
        //MainManager.Instance.BestScoreNamee.text = username;
    }

    // Update is called once per frame
    void Update()
    {
        //USERNAME = TMP_InputField.FindAnyObjectByType<TMP_InputField>();
    }

    //public void FindAllReferences()
    //{
    //    GameObject USERNAME = GameObject.FindWithTag("Nameinput");

    //    //ReferenceForMain.inostance.FindAllReferences();
    //}
}
