using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelfRotation : MonoBehaviour
{

    public Slider slider;
    public Toggle Direction;
    

    private float Speed;
    private bool IsStop;
    private bool IsRight;
    void Awake()
    {
        slider.onValueChanged.AddListener(x => OnSliderValueChanged(x));
    }
    // Update is called once per frame
    void Update()
    {
        if (!IsStop)
        {
            Transform selfTransform = this.gameObject.GetComponent<Transform>();
            int direction = IsRight ? -1 : 1;
            selfTransform.Rotate(Vector3.up * Speed * direction * 0.1f);
        }
    }

    void OnSliderValueChanged(float value)
    {
        if (value > 0)
            Speed = value * 10;
    }
}
