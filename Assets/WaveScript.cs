using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WaveScript : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 Location;
    public static int Wave = 1;
    public float targetTime = 5f;

    public int Enemies = 0;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        /*Debug.Log("wavescript logger, wave = " + Wave);*/
        targetTime -= Time.deltaTime;
        switch (Wave)
        {
            case 1:
                Wave1();
                break;

            case 2:
                Wave2();
                break;

            case 3:
                break;
        }
    }

    private void Wave1()
    {
        for (int i = 0; i < 10; i++)
        {
            if (targetTime < 0)
            {
                Instantiate(prefab, Location, Quaternion.identity);
                targetTime = 6;
                if (Enemies > 11)
                {
                    Wave++;
                }
            }
            break;

        }

    }

    private void Wave2()
    {
        for (int i = 0; i < 10; i++)
        {
            if (targetTime < 0)
            {
                Instantiate(prefab, Location, Quaternion.identity);
                targetTime = 4;
                if (Enemies > 10)
                {
                    Wave++;
                }
            }
            break;
        }
    }
}