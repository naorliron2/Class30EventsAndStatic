using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] float speed;

    private void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed) * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("PickUp"))
        {
            ScoreManger.Instance.addScore();
            Destroy(collision.gameObject);
        }
    }
}
