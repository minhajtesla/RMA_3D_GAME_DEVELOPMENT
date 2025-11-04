using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject target;

    public ParticleSystem blast;
    public AudioSource blastsound;
    public bool isdestroying;

    private void Start()
    {
        blast.Stop();
        blastsound.Stop();
    }

    private void Update()
    {
        if(isdestroying)
            target.transform.Rotate(Vector3.up * 500 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.X))
        {
            isdestroying = true;
            blast.Play();
                        blastsound.Play();
            OnDestroyobj();
        }
    }
    private void OnDestroyobj()
    {
        Destroy(target,1f);
    }
}
