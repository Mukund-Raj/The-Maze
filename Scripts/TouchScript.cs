using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class TouchScript : MonoBehaviour
{
    public FloatingJoystick MoveJoystick;
    public FixedTouchField TouchField;
    public Toggle running;
    private void Start()
    {
        running.isOn = false; 
    }
    void Update()
    {
        var fps = GetComponent<RigidbodyFirstPersonController>();
        fps.RunAxis = MoveJoystick.inputVector;
        fps.movementSettings.Run = running.isOn;
        fps.mouseLook.LookAxis= TouchField.TouchDist;
    }
}
