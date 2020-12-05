using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonScript : MonoBehaviour
{
    [SerializeField] Text myText;
    public static float num = 0;
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponentInChildren<Text>();
    }
    public void UpdateText()
    {
        myText.text = num.ToString();
    }
    public void addToNum()
    {
        num = MathClass.Add(num, 1);
    }
    // Update is called once per frame
    void Update()
    {
        UpdateText();
    }
}
