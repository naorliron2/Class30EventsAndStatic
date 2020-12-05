using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UnityEvents : MonoBehaviour
{
    public static UnityEvent OnPickUp;
    public UnityEvent FinishedPickups;
    UnityAction<int> test;
    [SerializeField]int score;
    [SerializeField] GameObject panel;
    [SerializeField] Text text;
    public void addScore()
    {
        score++;
        text.text = score.ToString();
    }
    public void pickedUpAll()
    {
        panel.SetActive(true);
    }
    private void Start()
    {
        OnPickUp.AddListener(addScore);
    }
    private void Update()
    {
        if (score == 4)
        {
            FinishedPickups.Invoke();
        }
    }


}
