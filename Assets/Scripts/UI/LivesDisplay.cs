using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class inherits for the UIelement class and handles updating the score display
/// </summary>
public class LivesDisplay : UIelement
{
    [Tooltip("The text UI to use for display")]
    public Text displayText = null;
    public Health health = null;


    /// <summary>
    /// Description:
    /// Updates the score display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void DisplayLives()
    {
        if (displayText != null)
        {
            displayText.text = "Lives: " + health.currentLives.ToString();
        }
    }

    /// <summary>
    /// Description:
    /// Overides the virtual UpdateUI function and uses the DisplayScore to update the score display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public override void UpdateUI()
    {
        // This calls the base update UI function from the UIelement class
        base.UpdateUI();

        // The remaining code is only called for this sub-class of UIelement and not others
        DisplayLives();
    }
}
