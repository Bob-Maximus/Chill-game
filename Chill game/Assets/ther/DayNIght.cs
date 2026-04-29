using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DayNIght : MonoBehaviour
{
    public float time;
    private Material sky;
    public Transform sun;
    public float daySpeed;

    public float timeOfDay;

    public void Awake()
    {
        sky = RenderSettings.skybox;
    }

    // Update is called once per frame
    void Update()
    {
        timeOfDay+=Time.deltaTime*daySpeed;
        //timeOfDay = time;

        if (timeOfDay > 24)
        {
            timeOfDay=0;
        }

        //sun.transform.rotation = Quaternion.Euler(timeOfDay*15, sun.transform.rotation.eulerAngles.y, sun.transform.rotation.eulerAngles.z);
        sun.transform.Rotate(Time.deltaTime*daySpeed*15, 0, 0);
        //sky.SetFloat("_AtmosphereThickness", timeOfDay);
    }
}
