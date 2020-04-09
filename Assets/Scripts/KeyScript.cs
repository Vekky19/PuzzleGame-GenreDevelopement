using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScript : MonoBehaviour
{
    ParticleSystem part;
    public Text keyText;

    private void Start()
    {
        part = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        part.Play();
        part.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        ScoreItemHandler.Instance.keys += 1;
        keyText.text = "KEYS: x" + ScoreItemHandler.Instance.keys.ToString();
        this.GetComponent<CircleCollider2D>().enabled = false;
        Destroy(this.gameObject, 1);

        //PlayerPrefs.SetInt("Keys", PlayerPrefs.GetInt("Keys") + 1);
    }

}
