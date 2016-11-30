using UnityEngine;
using System.Collections;

public class ColorChanger : MonoBehaviour {
    Renderer rend;
    Light lightc;
    // Use this for initialization
    void Start () {
        GameObject lightb = GameObject.FindGameObjectWithTag("Light");
        lightc = lightb.GetComponent<Light>();
        rend = GetComponent<Renderer>();
        rend.material.shader = Shader.Find("Standard");
        rend.material.color = Color.black;
        rend.material.SetColor("_EmissionColor", Color.black);
        
    }
	
	// Update is called once per frame
	void Update () {
        if (lightc.intensity== 8.0f )
        { 
           rend.material.color = Color.red;
           rend.material.SetColor("_EmissionColor", Color.red);

        }
	}
}
