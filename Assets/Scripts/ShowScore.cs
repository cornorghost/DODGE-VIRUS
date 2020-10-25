using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowScore : MonoBehaviour
{
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = LocalValue.score.ToString();
    }
}
