using UnityEngine;
using UnityEngine.UIElements;
using System.Collections;
using UnityEngine.Serialization;

public class MoveableMapController : MonoBehaviour
{
    // The UIDocument that contains the UI
    [FormerlySerializedAs("uiDocument")] public UIDocument _uiDocument;
    
    // The Visual Element to be animated
    private VisualElement _moveableMap;

    // The target offset for the animation
    private const float _slideDistance = 575f;
    private const float _animationDuration = 8.0f; // Duration in seconds
    
    // The curve to control the animation easing
    public AnimationCurve _easingCurve;
    
    void Start()
    {
        // Check if the UIDocument is assigned
        if (_uiDocument == null)
        {
            Debug.LogError("UIDocument is not assigned. Please assign it in the Inspector.");
            return;
        }

        // Get the root VisualElement
        var root = _uiDocument.rootVisualElement;

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
            // Calculate the progress of the animation (0 to 1)
            float progress = currentTime / duration;
        
            // Sample the easing curve at the current progress
            float easedProgress = _easingCurve.Evaluate(progress);

            // Calculate the new offset based on the eased progress
            float newOffset = Mathf.Lerp(startOffset, endOffset, easedProgress);
        
            // Apply the new offset to the style of the Visual Element
            _moveableMap.style.left = newOffset;
        
            currentTime += Time.deltaTime;
            yield return null; // Wait for the next frame
        }

        // Ensure the offset is exactly the end value to prevent floating point inaccuracies
        _moveableMap.style.left = endOffset;
    }
}