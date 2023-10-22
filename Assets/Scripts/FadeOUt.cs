using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOUt : MonoBehaviour
{
    SpriteRenderer rendereris;
    public float secons;

    private void Start()
    {
        rendereris = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        var color = rendereris.color;
        color.a -= Time.deltaTime * secons;

        rendereris.color = color;

    }
}
