using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using TreeEditor;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public Brick BrickPrefab;
    public int LineCount = 6;
    public Rigidbody Ball;

    public Text ScoreText;
    public Text BestScoreNamee;
    public GameObject GameOverText;

    public bool m_Started = false;
    private int m_Points;

    private bool m_GameOver = false;

    public static MainManager Instance;

    public int TextScore;


    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        if (int.TryParse(ScoreText.text, out int scoree))
            TextScore = scoree;
        //if (int.TryParse(ReferenceForMain.inostance.highScore, out int highscoreee))
        //    ReferenceForMain.inostance.liveScore = highscoreee;

                //BestScoreNamee = string(MenuUiHandler.instance.USERNAME.GetComponent<Text>());

                //string username = MenuUiHandler.instance.USERNAME.text;
                //BestScoreNamee.text = "Best Score: " + $" {ReferenceForMain.inostance.highScore}" + $" {ReferenceForMain.inostance.usaarname}";
        Debug.Log(BestScoreNamee.text);
        //if (SceneManager.sceneCount == 0)
        //{

    }

    public void bricks()
    {
        GameObject Paddlee = GameObject.Find("Paddle");
        Transform Ball = Paddlee.transform.Find("Ball");
        //Ball = Boll.;

        const float step = 0.6f;
        int perLine = Mathf.FloorToInt(4.0f / step);

        int[] pointCountArray = new[] { 1, 1, 2, 2, 5, 5 };
        for (int i = 0; i < LineCount; ++i)
        {
            for (int x = 0; x < perLine; ++x)
            {
                Vector3 position = new Vector3(-1.5f + step * x, 2.5f + i * 0.3f, 0);
                var brick = Instantiate(BrickPrefab, position, Quaternion.identity);
                brick.PointValue = pointCountArray[i];
                brick.onDestroyed.AddListener(AddPoint);
            }
        }
    }


    private void Update()
    {
        //GameObject canvass = GameObject.Find("Canvas");
        //Transform Gameover = canvass.transform.Find("GameoverText");

        //GameOverText = Gameover.gameObject;
        //BestScoreNamee = Gameover.GetComponent<Text>();

        if (!m_Started)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                m_Started = true;
                GameObject Scoretexti = GameObject.Find("ScoreText");
                ScoreText = Scoretexti.GetComponent<Text>();
                float randomDirection = Random.Range(-1.0f, 1.0f);
                Vector3 forceDir = new Vector3(randomDirection, 1, 0);
                forceDir.Normalize();

                Ball.transform.SetParent(null);
                Ball.AddForce(forceDir * 2.0f, ForceMode.VelocityChange);
            }
        }
        //if (m_Points > ReferenceForMain.inostance.liveScore)
        //{
        //    ReferenceForMain.inostance.liveScore = m_Points;
        //}

        else if (m_GameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //if (m_GameOver = true)
                //{
                    m_GameOver = false;
                    SceneManager.LoadScene(0);
                //}
            }
        }
    }

    public void AddPoint(int point)
    {
        //GameObject Scoretexti = GameObject.Find("ScoreText");
        //ScoreText = Scoretexti.GetComponent<Text>();
        m_Points += point;
        ScoreText.text = $"Score : {m_Points}";

        
    }

    public void GameOver()
    {
        m_Started = true;

        //Text GameOver = Text.Find("GameoverText");
        //GameOverText = Text.GetComponent<Text>();

        m_GameOver = true;
        GameObject canvass = GameObject.Find("Canvas");
        Transform Gameover = canvass.transform.Find("GameoverText");

        GameOverText = Gameover.gameObject;
        GameOverText.SetActive(true);
        //MainManager.Instance.GameOverText = GameObject.FindWithTag("GameOverTxt");
    }
}
