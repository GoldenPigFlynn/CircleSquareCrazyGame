using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Flash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FlashRemove();
    }

    void FlashRemove()
    {
        Destroy(gameObject, 0.09f);
    }
}
