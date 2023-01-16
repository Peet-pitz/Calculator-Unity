using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CalcButton : MonoBehaviour
{

    public TextMeshProUGUI label;

    public RectTransform rectTransform
    {
        get
        {
            if (_rectTransform == null)
                _rectTransform = GetComponent<RectTransform>();
            return _rectTransform;
        }
    }
    RectTransform _rectTransform;

    public CalcManager manager
    {
        get
        {
            if (_manager == null)
                _manager = GetComponentInParent<CalcManager>();
            return _manager;
        }
    } 
    static CalcManager _manager;
    // Start is called before the first frame update 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onTapped()
    {
        Debug.Log("Tapped: " + label.text);
        manager.buttonTapped(label.text[0]);
    }
}
