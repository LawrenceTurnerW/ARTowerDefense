using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        myPosition = this.transform.position;
    }

    [SerializeField]
    [Tooltip("召喚するオブジェクト")]
    private GameObject summon;

    public float span = 3f;
    private float currentTime = 0f;

    Vector3 myPosition = new Vector3();

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > span)
        {
            Debug.LogFormat("{0}秒経過", span);
            Instantiate(summon, new Vector3(myPosition.x, 0.01f, myPosition.z), Quaternion.identity);
            currentTime = 0f;
        }

    }
}
