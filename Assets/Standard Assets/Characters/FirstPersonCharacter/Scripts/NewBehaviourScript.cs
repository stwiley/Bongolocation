using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    // Use this for initialization
    void Start () {
        GetComponent<Light>().intensity = 0;

    }

    public float countdown = 5.0f;
    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Vertical1") && Input.GetButton("Vertical2") || Input.GetButton("Vertical1") && Input.GetButtonDown("Vertical2"))
        {

            GetComponent<Light>().intensity = 8.0f;
            Input.ResetInputAxes();
        }
        if (GetComponent<Light>().intensity == 8.0f) {
            countdown -= Time.deltaTime;
            if(countdown <= 0.0f)
            {
                GetComponent<Light>().intensity = 0.0f;
                countdown = 5.0f;
            }
        }


    }
}
