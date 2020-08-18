using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using najva;

public class InitializeNajva : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Najva.init();
        Najva.SetUserHandler(new UserCallback());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
