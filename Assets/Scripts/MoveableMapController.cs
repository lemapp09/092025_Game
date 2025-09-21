using UnityEngine;
using UnityEngine.UIElements;
using System.Collections;

public class MoveableMapController : MonoBehaviour
{
    // The UIDocument that contains the UI
    public UIDocument uiDocument;
    
    // The Visual Element to be animated
    private VisualElement _moveableMap;

    // The target offset for the animation
    private const float _slideDistance = 575f;
    private const float _animationDuration = 8.0f; // Duration in seconds
    
    void Start()
    {
        // Check if the UIDocument is assigned
        if (uiDocument == null)
        {
            Debug.LogError("UIDocument is not assigned. Please assign it in the Inspector.");
            return;
        }

        // Get the root VisualElement
        var root = uiDocument.rootVisualElement;

        // Locate the MoveableMap Visual Element by its name
        _moveableMap = root.Q<VisualElement>("MoveableMap");

        if (_moveableMap == null)
        {
            Debug.LogError("Visual Element 'MoveableMap' not found in the UI Document.");
            return;
        }

        // Start the sliding animation coroutine
        StartCoroutine(SlideMap());
    }

    private IEnumerator SlideMap()
    {
        // Infinite loop to slide back and forth
        while (true)
        {
            // Slide from Left 0 to Left 512
            yield return StartCoroutine(AnimateOffset(0f, -_slideDistance, _animationDuration));

            // Slide from Left 512 back to Left 0
            yield return StartCoroutine(AnimateOffset(-_slideDistance, 0f, _animationDuration));
        }
    }

    private IEnumerator AnimateOffset(float startOffset, float endOffset, float duration)
    {
        float currentTime = 0f;

        while (currentTime < duration)
        {
            // Calculate the new offset based on a linear interpolation
            float newOffset = Mathf.Lerp(startOffset, endOffset, currentTime / duration);
            
            // Apply the new offset to the style of the Visual Element
            _moveableMap.style.left = newOffset;
            
            currentTime += Time.deltaTime;
            yield return null; // Wait for the next frame
        }

        // Ensure the offset is exactly the end value to prevent floating point inaccuracies
        _moveableMap.style.left = endOffset;
    }
}