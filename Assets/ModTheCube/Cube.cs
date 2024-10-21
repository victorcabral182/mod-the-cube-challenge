using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private Vector3 initialPosition = new Vector3(3, 4, 1);
    private float redColor;
    private float greenColor;
    private float blueColor;
    private float opacity;

    private float xRotate;
    private float yRotate;
    private float zRotate;


    void Start()
    {
        transform.position = initialPosition;
        Material material = Renderer.material;
        material.color = new Color(redColor, greenColor, blueColor, opacity);
        InvokeRepeating("HandleChangeCubeColor", 1.0f, 2.0f);
    }

    void Update()
    {
        transform.Rotate(xRotate * Time.deltaTime, yRotate * Time.deltaTime, zRotate * Time.deltaTime);
    }

    void HandleChangeCubeColor()
    {
        redColor = Random.Range(0.0f, 1.0f);
        greenColor = Random.Range(0.0f, 1.0f);
        blueColor = Random.Range(0.0f, 1.0f);
        opacity = Random.Range(0.1f, 1.0f);

        xRotate = Random.Range(0.0f, 150.0f);
        yRotate = Random.Range(0.0f, 150.0f);
        zRotate = Random.Range(0.0f, 150.0f);

        Renderer.material.color = new Color(redColor, greenColor, blueColor, opacity);
    }
}
