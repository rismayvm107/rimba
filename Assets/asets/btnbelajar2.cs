using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnbelajar2 : MonoBehaviour
{
    public GameObject Materi2;
    public GameObject Materi3;
    // Start is called before the first frame update
    void Start()
    {
        Materi2.SetActive(true);
        Materi3.SetActive(false);   
    }
public void btnselanjutnyaClicked()
{
    Materi2.SetActive(false);
        Materi3.SetActive(true);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
