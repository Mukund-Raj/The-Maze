using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class TouchScript2 : MonoBehaviour
{
    public FloatingJoystick MoveJoystick;
    public FixedTouchField TouchField;
    public FixedButton fix;
    public Toggle run;
    public Door_Open d1;
    // Update is called once per frame
    private void Start()
    {
        run.isOn = false;
        d1.clicked = false;
    }
    void Update()
    {
        var fps = GetComponent<RigidbodyFirstPersonController>();
        fps.RunAxis = MoveJoystick.inputVector;
        fps.movementSettings.Run = run.isOn;
        fps.mouseLook.LookAxis = TouchField.TouchDist;
        d1.clicked = fix.Pressed;
    }
}
