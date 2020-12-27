using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateNew : MonoBehaviour
{
    [SerializeField] GameObject instance;
    public void createNewInstance()
    {
        Instantiate(instance);
    }
}
