using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class audioScript : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public VirtualButtonBehaviour vbBtnObj;
    public AudioSource fuente;
    public AudioClip clip;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GetComponent<VirtualButtonBehaviour>();
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        fuente.clip = clip;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        fuente.Play();
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        fuente.Stop();
        Debug.Log("Button released");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
