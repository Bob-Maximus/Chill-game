using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNIght : MonoBehaviour
{
    public float timeOfDay;
    public Material sky;


    // Update is called once per frame
    void Update()
    {
        timeOfDay+=Time.deltaTime;
        float weather = timeOfDay;
        sky.SetFloat("Atmosphere Thickness", weather);
    }
}
