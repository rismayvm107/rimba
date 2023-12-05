using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnkembali2 : MonoBehaviour
{
    public GameObject Materi3;
    public GameObject Materi2;
    // Start is called before the first frame update
    void Start()
    {
        Materi3.SetActive(true);
        Materi2.SetActive(false);    
    }
public void btnsebelumnyaClicked()
{
    Materi3.SetActive(false);
        Materi2.SetActive(true);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
