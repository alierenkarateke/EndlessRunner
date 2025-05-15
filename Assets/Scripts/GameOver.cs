using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
[SerializeField] GameObject gameOverPanel;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void Restrat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
