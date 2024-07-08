using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BirdieScript : MonoBehaviour
{

    public int value;
    public TextMeshPro tmp;

    int[] possibleScores = { 10, 20, 30 };

    // Start is called before the first frame update
    void Start()
    {
        value = possibleScores[Random.Range(1, possibleScores.Length - 1)];
        transform.GetChild(0).GetComponent<TextMeshPro>().text = value.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }
}