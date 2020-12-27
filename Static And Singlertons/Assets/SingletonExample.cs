using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SingletonExample : MonoBehaviour
{
    #region singleton
    private static SingletonExample _instance;

    public static SingletonExample Instance { get { return _instance; } }


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
   

}
