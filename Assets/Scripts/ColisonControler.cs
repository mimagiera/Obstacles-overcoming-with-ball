using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisonControler : MonoBehaviour {
    public GameObject fence;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Quad 1"))
        {
            fence.SetActive(false);
        }
    }
}
