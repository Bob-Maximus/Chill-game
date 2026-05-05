using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScreen : MonoBehaviour
{
    public Image blur;
    float blackness = 0;

    public RectTransform image;
    public float height;

    void Update()
    {
        if (gameObject.activeInHierarchy)
        {
            blackness = Mathf.Lerp(blackness, 1, Time.unscaledTime*0.001f);
            blur.color = new Vector4(0, 0, 0, blackness);

            image.position = Vector3.Lerp(image.transform.position, new Vector3(297.58f, height, 0), Time.unscaledTime*0.005f);
        }
    }
}
