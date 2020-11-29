using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerManager : NetworkBehaviour
{
    [SerializeField]
    GameObject _playerPrefab;

    GameObject _player;
    CameraMovement _playerCamMov;
    PlayerMovementStandarized _playerMov;

    UIManager uim;

    public bool isPaused = false;

    [SerializeField]
    ParticipantTypes userType = ParticipantTypes.Participant;

    void Start()
    {
        if (isLocalPlayer)
        {
            uim = GameObject.Find("UIManager").GetComponent<UIManager>();
            SpawnPlayer();
        }
    }

    private void Update()
    {
        if (isLocalPlayer)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Cursor.lockState = Cursor.lockState == CursorLockMode.Locked ? CursorLockMode.None : CursorLockMode.Locked;
                PauseGame(!isPaused);
                uim.SetPauseUI(isPaused);
            }
        }
    }

    [Command]
    void SpawnPlayer()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 1)
        {
            userType = ParticipantTypes.Host;
        }

        _player = Instantiate(_playerPrefab);
        _playerCamMov = _player.GetComponentInChildren<CameraMovement>();
        _playerMov = _player.GetComponent<PlayerMovementStandarized>();

        _playerMov.SetPlayerManager(this);

        NetworkServer.Spawn(_player, connectionToClient);
    }

    [Client]
    void PauseGame(bool setPause)
    {
        isPaused = setPause;
    }

    [Client]
    public void ExitGame()
    {
        Application.Quit();
    }

    [Client]
    public void ResumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        PauseGame(false);
        Debug.Log(uim);
        uim.SetPauseUI(false);
    }
}
