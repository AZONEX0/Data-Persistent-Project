using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReferenceForMain : MonoBehaviour
{
    public string usaarname;
    public TMP_InputField USERNAME;

    public int highScoreNmber;

    public string HighestScoreString; // to store the highest score
    public string HighestScoreName; // to store highest scorer username

    public string HighScoreString; // to convert int to string and string to text

    public int scorri;

    public static ReferenceForMain inostance;

    private void Awake()
    {
        if (inostance != null)
        {
            Destroy(gameObject);
            return;
        }
        inostance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HighestScoreString = "0";
        HighScoreString = "0";
        LoadHighScore();
    }

    // can be used to display username as well but wasnt looking good. gets and stores the username.
    public string UsernameSubmit()
    {
        USERNAME = TMP_InputField.FindAnyObjectByType<TMP_InputField>();
        usaarname = USERNAME.text;
        string username = new string(usaarname);
        //Debug.Log(USERNAME);
        return usaarname;
    }

    public void AssignReferences()
    {
        GameObject BestScori = GameObject.Find("BestScoreName");
        MainManager.Instance.BestScoreNamee = BestScori.GetComponent<Text>();
    }

    // a bit misleading but thats what i made it do first. it compares the current score and highest score.
    public void HighScoreUpdate()
    {
        scorri = MainManager.Instance.m_Points;
        MainManager.Instance.BestScoreNamee.text = "Best Score: " + $" {HighestScoreString}" + $" {HighestScoreName}";
        if (highScoreNmber < scorri)
        {
            highScoreNmber = scorri;
            HighScoreString = highScoreNmber.ToString();
        }

        if (int.Parse(HighestScoreString) < int.Parse(HighScoreString))
        {
            HighestScoreString = HighScoreString;
            HighestScoreName = usaarname;
            SaveHighScore();
        }
    }

    [System.Serializable]
    class SaveData
    {
        public string HighestScoreString;
        public string HighestScoreName;
    }

    public void SaveHighScore()
    {
        SaveData datai = new SaveData();
        datai.HighestScoreString = HighestScoreString;
        datai.HighestScoreName = HighestScoreName;

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
            HighestScoreName = datai.HighestScoreName;
        }
    }
}
