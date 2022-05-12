using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CounterScript : MonoBehaviour
{

    public TextMeshProUGUI enemyCountText;
    public static int enemiesValue;

    // Start is called before the first frame update
    void Start()
    {
        enemyCountText = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        enemyCountText.text = "" + enemiesValue;
    }
}