using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsobiClose : MonoBehaviour
{
    [SerializeField] GameObject m_audioPrehab;
    // Start is called before the first frame update
    public GameObject asobi;
    //public GameObject startBu;

    // Update is called once per frame
    public void OnClick()
    {
        if(m_audioPrehab)
        {
            Instantiate(m_audioPrehab);
        }

        asobi.gameObject.SetActive(false);
        //startBu.gameObject.SetActive(true);
    }
}
