using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == MyTags.PLAYER_TAG)
        {
            target.GetComponent<PlayerDamage>().DealDamage();
            gameObject.SetActive(false);
            SceneManager.LoadScene("MainMenu");
           // StartCoroutine(RestartGame());
        }
    }
}
