using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    public MainManager Manager;

    private void OnCollisionEnter(Collision other)
    {
        //MainManager.Instance.GameOverText = GameObject.FindWithTag("GameOverTxt");
        Destroy(other.gameObject);
        MainManager.Instance.GameOver();
        
    }
}
