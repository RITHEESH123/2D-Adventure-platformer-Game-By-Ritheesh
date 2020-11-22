using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public Text coinTextScore;
    private AudioSource audioManager;
    private int scoreCount = 0;

    void Awake()
    {
        audioManager = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        coinTextScore = GameObject.Find("CoinText").GetComponent<Text>();
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == MyTags.COIN_TAG)
        {
            target.gameObject.SetActive(false);
            scoreCount++;

            coinTextScore.text = "x" + scoreCount;
            audioManager.Play();
        }
    }

   
}
