using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseManager : MonoBehaviour
{
    public Canvas losecanvas;
    private void Start()
    {
        Time.timeScale = 1;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            Instantiate(losecanvas, transform.position, Quaternion.identity);
        }

    }
}
