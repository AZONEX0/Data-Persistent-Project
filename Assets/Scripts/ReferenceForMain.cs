using TMPro;
using UnityEngine;

public class ReferenceForMain : MonoBehaviour
{
    public string usaarname;
    public TMP_InputField USERNAME;

    public static ReferenceForMain inostance;

    private void Awake()
    {
        if (inostance != null)
        {
            Destroy(gameObject);
            return;
            //}
            //else if (Instance = null)
            //{
            //    Instantiate(gameObject);
        }

        inostance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public string UsernameSubmit()
    {
        string username = USERNAME.text;
        usaarname = username;
        Debug.Log(USERNAME);
        return usaarname;
        //MainManager.Instance.BestScoreNamee.text = username;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
