using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinManager : MonoBehaviour
{
    Player1Movement player1;
    Player2Movement player2;
    public Canvas WinCanvas;
    bool IsCalled = false;

    public void Start()
    {
        player1 = FindObjectOfType<Player1Movement>();
        player2 = FindObjectOfType<Player2Movement>();
        /*
                var P1zPos = player1.transform.position.z <= -1;
                var P2zPos = player2.transform.position.z >= 110;
                var P1xPos = player1.transform.position.x <= -28 && player1.transform.position.x >= -45;
                var P2xPos = player2.transform.position.x <= -28 && player2.transform.position.x >= -45;*/
    }
    public void Update()
    {

        if (player1.transform.position.z <= -1 &&
            player2.transform.position.z >= 110 &&
            player1.transform.position.x <= -28 && player1.transform.position.x >= -45 &&
            player2.transform.position.x <= -28 && player2.transform.position.x >= -45)
        {
            Time.timeScale = 0;
            if (IsCalled == false)
            {
                Instantiate(WinCanvas, transform.position, Quaternion.identity);
                IsCalled = true;
            }
        }
        if (player1.transform.position.z <= -1 &&
            player2.transform.position.z >= 110 &&
            player1.transform.position.x <= -28 && player1.transform.position.x >= -45 &&
            player2.transform.position.x <= -28 && player2.transform.position.x >= -45 &&
            SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 5"))
        {
            SceneManager.LoadScene("Last Credits");
        }
       
    }
}