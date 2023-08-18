using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GBMove : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    [SerializeField] private float animSpeed = 1f;
    
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animSpeed * Time.deltaTime, 0);
    }
}
