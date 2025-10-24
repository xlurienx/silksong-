using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinspawn : MonoBehaviour
{
    // Update is called once per frame

    public void GetBumped()
    {
       Destroy(gameObject);
    }
}
