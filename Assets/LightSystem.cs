using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSystem : MonoBehaviour
{
    public GameObject Light;

    void Update()
    {
        Light.transform.Rotate (5.0f * Time.deltaTime, 0, 0);
    }
}
