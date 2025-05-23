using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{

    [SerializeField] Text scoreText;
    private float score;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString(); 
        }
    }
}
