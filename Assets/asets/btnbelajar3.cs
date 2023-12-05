using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnbelajar3 : MonoBehaviour
{
    public GameObject Materi3;
    public GameObject Materi4;
    // Start is called before the first frame update
    void Start()
    {
        Materi3.SetActive(true);
        Materi4.SetActive(false); 
    }
public void btnselanjutnyaClicked()
{
    Materi3.SetActive(false);
        Materi4.SetActive(true);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
