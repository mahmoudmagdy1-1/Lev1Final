using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndEffect : MonoBehaviour
{
    [SerializeField] float time;
    void Start()
    {
        Invoke("EndingEffect", time);
    }
    void EndingEffect()
    {
        Destroy(gameObject);
    } 
}
