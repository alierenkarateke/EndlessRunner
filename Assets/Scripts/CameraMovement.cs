using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]float cameraSpeed;

    // Update is called once per frame
    void Update()
    {

        // Kamera x ekseninde düzenli olarak ilerler 
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
