using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;
    private ScoreScript scoreScript;
    public enum BulletType
    {
        Bullet,
        Rocket
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreScript = FindObjectOfType<ScoreScript>();
        Destroy(gameObject, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name != "GunEnd" && collision.gameObject.name != "Player1")
        {

            if (collision.gameObject.CompareTag("Enemy"))
            {
                scoreScript.score += collision.gameObject.GetComponent<BirdieScript>().value;
                Destroy(collision.gameObject);
            }
            Destroy(gameObject);
        }
        if (tag == "Pillar" || tag == "Sky" || tag == "Grass")
        {
        }
    }
}