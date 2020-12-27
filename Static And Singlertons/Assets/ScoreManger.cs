using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManger : MonoBehaviour
{
    #region singleton
    private static ScoreManger _instance;

    public static ScoreManger Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Debug.Log("An instance already exists, destroying");
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    #endregion
    
    private int score = 0;
    [SerializeField] Text text;

    public void addScore()
    {
        score++;
        text.text = score.ToString();
    }
}
