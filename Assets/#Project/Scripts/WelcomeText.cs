using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WelcomeText : MonoBehaviour
{

    public TextMeshProUGUI welcomeText;
    public float timer = 3f;
    void Start()
    {
        welcomeText.text = "Bonjour, je m'appelle Pixie! Je suis ici pour papoter avec vous!";

    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;
        if (timer <= 0) { welcomeText.text = ""; }

    }
}
