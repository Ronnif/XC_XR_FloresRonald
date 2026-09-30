using UnityEngine;

public class ColorChangeOnSelect : MonoBehaviour
{
    private Renderer objectRenderer;
    private Color originalColor;
    public Color newColor = Color.magenta;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
    }

    public void ToggleColor()
    {
        if (objectRenderer.material.color == originalColor)
            objectRenderer.material.color = newColor;
        else
            objectRenderer.material.color = originalColor;
    }
}