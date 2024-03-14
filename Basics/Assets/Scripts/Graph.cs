using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Graph : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab = default;
    [SerializeField, Range(10, 100)]
    int resolution = 10;
    Transform[] points;

    void Awake() {
        float step = 2f / resolution;
        var position = Vector3.zero;
        var scale = Vector3.one * step;

        points = new Transform[resolution];
        for (int i = 0; i < points.Length; i++){
            Transform point = points[i] = Instantiate(pointPrefab);
            position.x = (i + 0.5f) * step - 1f;            
            point.localPosition = position;
            point.localScale = scale;
            point.SetParent(transform, false);
        }
    }

    void Update() {
        for (int i = 0; i < points.Length; i++){
            Transform point = points[i];
            Vector3 position = point.localPosition;
            position.y = Mathf.Sin(Mathf.PI * (position.x + Time.time));
            point.localPosition = position;
        }
    }
}
