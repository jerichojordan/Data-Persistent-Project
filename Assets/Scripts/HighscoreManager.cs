using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighscoreManager : MonoBehaviour
{
    public static HighscoreManager Instance;
    public int highscore;
    public string playerName;
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(Instance);
    }
    [Serializable]
    public class SaveHighscore
    {
        public int savedHighscore;
        public string savedPlayerName;
    }
    
    
}
