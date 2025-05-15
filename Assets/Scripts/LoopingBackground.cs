using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    [SerializeField] float backgroundSpeed;
    [SerializeField] Renderer backgroundRenderer;
    // Update is called once per frame
    void Update()
    {
        // Texture offset düzenli olarak artar ve ilerliyormuş gibi bir görüntü ortaya çıkar
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0);
    }
}
