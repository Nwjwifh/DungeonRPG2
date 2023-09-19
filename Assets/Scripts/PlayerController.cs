using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerSO playerData; // Player 스크립터블 오브젝트 참조

    private void Start()
    {
        // Player 스크립터블 오브젝트를 찾아서 참조
        playerData = Resources.Load<PlayerSO>("SO/Player"); // Resources 폴더 경로에 맞게 조정하세요.

        // 플레이어 스탯 초기화 또는 다른 로직을 여기에 추가
    }
}
