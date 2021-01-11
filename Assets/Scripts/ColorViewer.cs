using UnityEngine;
using UnityEngine.UI;

public class ColorViewer : MonoBehaviour
{
    public MultiSourceManager _MultiManager;
    public RawImage _ColorImage;

    void Update()
    {
        _ColorImage.texture = _MultiManager.GetColorTexture();
    }
}
