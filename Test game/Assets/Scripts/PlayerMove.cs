using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _runSpeed;
    private float _oldMousePositionX;
    private float _eulerY;
    [SerializeField] Animator _animatorMichelle;
    [SerializeField] Animator _animatorMan;


    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _oldMousePositionX = Input.mousePosition.x;
            _animatorMichelle.SetBool("Run", true);
            _animatorMan.SetBool("Run", true);
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 newPosition = transform.position + Time.deltaTime * transform.forward * _runSpeed;
            newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
            transform.position = newPosition;

            // Поворот за курсором
            //var diff = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            //var angel = diff.normalized.x * 180 / Mathf.PI;
            //transform.eulerAngles = Vector3.up * angel;

            float deltaX = Input.mousePosition.x - _oldMousePositionX;
            _oldMousePositionX = Input.mousePosition.x;

            _eulerY += deltaX;
            _eulerY = Mathf.Clamp(_eulerY, -70, 70);
            transform.eulerAngles = new Vector3(0, _eulerY * 0.7f, 0);
        }

        if (Input.GetMouseButtonUp(0))
        {
            _animatorMichelle.SetBool("Run", false);
            _animatorMan.SetBool("Run", false);
        }
        if (Input.GetKey("o"))
        {
            _animatorMichelle.SetTrigger("Dance");
            _animatorMan.SetTrigger("Dance");
        }
    }
}
