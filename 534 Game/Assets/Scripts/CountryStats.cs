﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountryStats : MonoBehaviour {

    public static int Population = 7000000;
    public static float Healthcare = 75.00f;
    public static float GDP = 1250.37f;

    public Text[] texts;

    private void Update()
    {
        texts[0].text = Population.ToString();
        texts[1].text = Healthcare.ToString();
        texts[2].text = GDP.ToString();
    }
}
