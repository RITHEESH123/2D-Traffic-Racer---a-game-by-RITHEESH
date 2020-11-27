using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    private Renderer r;
    public float speed = 0.5f;
    private Vector2 offset;

    void Awake()
    {
        r = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(0f, Time.time * speed);
        r.material.mainTextureOffset = offset;
    }
}
