using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReferenceForMain : MonoBehaviour
{
    public string usaarname;
    public TMP_InputField USERNAME;

    //public Text HIGHSCORETXT;
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

        HighestScoreString = "0";
        HighScoreString = "0";
        LoadHighScore();
        Debug.Log(Application.persistentDataPath);
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

    //public string usernametest()
    //{
    //    string username = new string(usaarname);
    //    return usaarname;
    //}

    // Update is called once per frame
    void Update()
    {
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

        //int HighScoreCheck = highScoreNmber;
        //highScoreNmber = 0;
        //if (highScore < MainManager.Instance.ScoreText)
        //MainManager.Instance.BestScoreNamee.text = 
        scorri = MainManager.Instance.m_Points;
        MainManager.Instance.BestScoreNamee.text = "Best Score: " + $" {HighestScoreString}" + $" {usaarname}";
        if (highScoreNmber < scorri)
        {
            highScoreNmber = scorri;
            HighScoreString = highScoreNmber.ToString();
            //HighestScoreString = HighScoreString;
        }
        if (int.Parse(HighestScoreString) < int.Parse(HighScoreString))
        {
            //highScoreNmber = scorri;
            //HighScoreString = highScoreNmber.ToString();
            HighestScoreString = HighScoreString;
            // MAKE ANOTHER VARIABLE LIKE HIGHEST SCORE STRING HERE TO SAVE THE NAME AS WELL. AYBE THAT WILL WORK
            SaveHighScore();
            //MainManager.Instance.SaveHighScoreN();
        }
    }

    [System.Serializable]
    class SaveData
    {
        public string HighestScoreString;
        public string usaarname;
    }

    public void SaveHighScore()
    {
        SaveData datai = new SaveData();
        datai.HighestScoreString = HighestScoreString;
        datai.usaarname = usaarname;

        string Json = JsonUtility.ToJson(datai);

        File.WriteAllText(Application.persistentDataPath + "/save1.json", Json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/save1.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData datai = JsonUtility.FromJson<SaveData>(json);

            HighestScoreString = datai.HighestScoreString;
            usaarname = datai.usaarname;
        }
    }
}
