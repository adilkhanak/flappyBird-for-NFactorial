using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private MeshRenderer _meshRenderer;
    private Vector2 _meshOffset; 
    // Start is called before the first frame update
    void Start()
    {
        _meshOffset= _meshRenderer.sharedMaterial.mainTextureOffset;
    }

    // Update is called once per frame
    void OnDisable()
    {
        _meshRenderer.sharedMaterial.mainTextureOffset = _meshOffset;
    }
    void Update()
    {
        var x = Mathf.Repeat(Time.time * _speed,1);
        var offset = new Vector2(x,_meshOffset.y);
        _meshRenderer.sharedMaterial.mainTextureOffset=offset;
    }
}
