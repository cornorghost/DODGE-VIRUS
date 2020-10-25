using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counting : MonoBehaviour
{
    public TextMeshProUGUI txt;

    // Start is called before the first frame update
    void Start()
    {
        LocalValue.score = 0.0f;
        txt = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        LocalValue.score += Time.deltaTime;
        txt.text = LocalValue.score.ToString();
    }
}
