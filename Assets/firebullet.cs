using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class firebullet : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnpoint;
    public float firespeed = 20;
    void Start()
    {
       XRGrabInteractable GrabInteractable = GetComponent<XRGrabInteractable>();
        GrabInteractable.activated.AddListener(FireBullet);
    }

    void Update()
    {
        
    }
    void FireBullet(ActivateEventArgs arg)
    {
        GameObject spawnbullet = Instantiate(bullet);
        spawnbullet.transform.position = spawnpoint.position;
        spawnbullet.GetComponent<Rigidbody>().velocity = spawnpoint.forward * firespeed;
        Destroy(spawnbullet, 10);
    }
}
