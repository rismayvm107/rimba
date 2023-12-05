using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnkembali3 : MonoBehaviour
{
    public GameObject Materi2;
    public GameObject Materi1;
    // Start is called before the first frame update
    void Start()
    {
        Materi2.SetActive(true);
        Materi1.SetActive(false);  
    }
public void btnsebelumnyaClicked()
{
    Materi2.SetActive(false);
        Materi1.SetActive(true);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
