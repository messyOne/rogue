using UnityEngine;
using System.Collections;
using System.Runtime.Serialization.Formatters;

public class Loader : MonoBehaviour
{

    public GameObject gameManager;

    void Awake()
    {
        if (GameManager.instance == null)
        {
            Instantiate(gameManager);
        }
    }
}
