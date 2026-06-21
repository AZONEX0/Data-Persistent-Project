using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReferenceForMain : MonoBehaviour
{
    public string usaarname;
    public TMP_InputField USERNAME;

    public Text HIGHSCORETXT;
    public int highScoreNmber;
    public string HighestScoreString;
    public string HighScoreString; // to convert int to string and string to text

    //public int liveScore;
    public int scorri;

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
        usaarname = USERNAME.text;
        //string username = USERNAME.text;
        string username = new string(usaarname);
        //usaarname = username;
        Debug.Log(USERNAME);
        return usaarname;
        //MainManager.Instance.BestScoreNamee.text = username;
    }

    // Update is called once per frame
    void Update()
    {
        HighScoreUpdate();
    }

    public void FindAllReferences()
    {
        //GameObject Scoretexti = GameObject.Find("ScoreText");
        //MainManager.Instance.ScoreText = Scoretexti.GetComponent<Text>();

        GameObject BestScori = GameObject.Find("BestScoreName");
        MainManager.Instance.BestScoreNamee = BestScori.GetComponent<Text>();
        //MainManager.Instance.BestScoreNamee.text = "Best Score: " + $" {HighestScoreString}" + $" {ReferenceForMain.inostance.usaarname}";

        //GameObject GameOva = GameObject.Find("ScoreText");
    }

    public void HighScoreUpdate()
    {
        //HighScoreString = HIGHSCORETXT.text;
        //int HiSc = int.Parse(HighScoreString);

        scorri = MainManager.Instance.m_Points;
        highScoreNmber = 0;
        if(highScoreNmber < scorri)
        {
            highScoreNmber = scorri;
            HighScoreString = highScoreNmber.ToString();
            HighestScoreString = HighScoreString;
        }
        MainManager.Instance.BestScoreNamee.text = "Best Score: " + $" {HighestScoreString}" + $" {ReferenceForMain.inostance.usaarname}";
        //if (highScore < MainManager.Instance.ScoreText)
        //MainManager.Instance.BestScoreNamee.text = 
    }
}
