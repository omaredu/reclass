using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovementStandarized : NetworkBehaviour
{
    [SerializeField]
    float _speed = 10;

    [SerializeField]
    bool _isFreezed = false;

    CharacterController _charCont;

    PlayerManager pm;

    // Start is called before the first frame update
    void Start()
    {
        _charCont = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        if (hasAuthority)
        {
            if (!_isFreezed || !pm.isPaused)
            {
                float x = Input.GetAxis("Horizontal"), z = Input.GetAxis("Vertical");

                Vector3 move = transform.right * x + transform.forward * z;

                _charCont.Move(move * _speed * Time.fixedDeltaTime);
            }
        }
    }

    public void SetPlayerManager(PlayerManager pm)
    {
        this.pm = pm;
    }
}
