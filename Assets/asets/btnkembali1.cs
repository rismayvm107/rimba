using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnkembali1 : MonoBehaviour
{
    public GameObject Materi4;
    public GameObject Materi3;
    // Start is called before the first frame update
    void Start()
    {
        Materi4.SetActive(true);
        Materi3.SetActive(false);   
    }
public void btnsebelumnyaClicked()
{
    Materi4.SetActive(false);
        Materi3.SetActive(true);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
