using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    private float timer = 0f;
    public TextMeshProUGUI contadorText;
    void Update()
    {
        timer += Time.deltaTime;
        contadorText.text =  timer.ToString("F0");
    }
}
