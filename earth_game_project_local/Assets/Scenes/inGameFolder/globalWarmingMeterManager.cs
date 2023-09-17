using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class globalWarmingMeterManager : MonoBehaviour
{
    public Slider globalWarmingMeter;
    public TextMeshProUGUI meterText;
    public float warmingValue;
    // Start is called before the first frame update
    void Start()
    {
        warmingValue = 550; // 55%
        globalWarmingMeter.maxValue = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        globalWarmingMeter.value = warmingValue;
        meterText.text = ((globalWarmingMeter.value/10).ToString()+"%");
    }
}
