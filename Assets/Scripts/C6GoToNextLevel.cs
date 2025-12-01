using UnityEngine.SceneManagement;

// This interaction loads another scene
public class C6GoToNextLevel : C6PressKey
{
    public string nameOfNextLevel = "";

    // protected: this method is accessible in child classes
    // override: this method is overriding the base class implementation
    protected override void OnKeyPressed()
    {
        // First, call the base implementation in case there is a common logic to execute
        base.OnKeyPressed();

        // Then, implement the behaviour of this specifc interaction type:
        // HANDS-ON: load another scene by calling the function SceneManager.LoadScene and a name of a scene as its argument
        SceneManager.LoadScene(nameOfNextLevel);
    }
}
