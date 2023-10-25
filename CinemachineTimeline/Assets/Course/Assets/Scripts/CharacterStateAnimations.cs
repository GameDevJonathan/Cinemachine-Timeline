using UnityEngine;

public class CharacterStateAnimations : MonoBehaviour
{
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.K))
        {
            _animator.SetTrigger("Death");
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            _animator.SetBool("IsAiming", true);
        }
        
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            _animator.SetBool("IsAiming", false);
        }

        
    }
}
