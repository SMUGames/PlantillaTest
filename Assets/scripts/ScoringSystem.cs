using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public short score = 0;

    void OnTriggerEnter(Collider other)
    {
        score += 50;
        scoreText.GetComponent<Text>().text = "Score: " + score;
        
        Destroy(gameObject);
    }

}
