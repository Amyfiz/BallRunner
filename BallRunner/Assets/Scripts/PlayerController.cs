using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //public Button ButtonUp;
    [SerializeField] int time;
    
    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(FlyUp());
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            StopCoroutine(FlyUp());
        }
    }

    IEnumerator  FlyUp()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.1f, 0);
        yield return new WaitForSeconds(time);
    }
}
