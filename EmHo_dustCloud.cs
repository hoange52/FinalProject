using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmHo_dustCloud : MonoBehaviour
{

    private GameObject dustCloud;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Ground")) ;
        Instantiate(dustCloud, transform.position, dustCloud.transform.rotation);
    }
}
