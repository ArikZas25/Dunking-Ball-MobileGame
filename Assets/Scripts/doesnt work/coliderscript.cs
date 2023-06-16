using System.Collections;
using UnityEngine;

public class coliderscript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ring")
        {
            Destroy(col.gameObject);
        }
    }
}
