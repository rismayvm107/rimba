using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnbelajar1 : MonoBehaviour
{
    public GameObject Materi1;
    public GameObject Materi2;
    // Start is called before the first frame update
    void Start()
    {
        Materi1.SetActive(true);
        Materi2.SetActive(false);    
    }
public void btnselanjutnyaClicked()
{
    Materi1.SetActive(false);
        Materi2.SetActive(true);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
