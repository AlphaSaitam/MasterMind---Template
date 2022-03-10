
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class Manager : MonoBehaviour
{
    private Color[] Colors = {Color.red, Color.blue, Color.green, Color.yellow};
    public Color[] answer = new Color[4];
    public Line[] lines;

    void Start()
    {
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = Colors[Random.Range(0, 4)];
        }
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MouseRaycast();
        }

    }

    private void MouseRaycast()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.GetComponent<Sphere>() != null)
            {
                Debug.Log("touch !");
                hit.collider.gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color",Color.green);
            }
        }
    }
}
