using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    // Reference to the TextMesh component
    public TextMesh textMesh;

    void Start()
    {
        // Optionally, you can find the TextMesh component on the same GameObject
        if (textMesh == null)
        {
            textMesh = GetComponent<TextMesh>();
        }
    }

    void Update()
    {
        // Check for a key press to change the text
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeTextMesh("New Text!");
        }
    }

    public void ChangeTextMesh(string newText)
    {
        if (textMesh != null)
        {
            textMesh.text = newText;
        }
    }
}
