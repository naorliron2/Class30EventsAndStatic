using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] UnityEvents eventScript;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            eventScript.OnPickUp.Invoke();
            gameObject.SetActive(false);
        }

    }
}
