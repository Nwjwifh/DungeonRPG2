using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerSO playerData; // Player ��ũ���ͺ� ������Ʈ ����

    private void Start()
    {
        // Player ��ũ���ͺ� ������Ʈ�� ã�Ƽ� ����
        playerData = Resources.Load<PlayerSO>("SO/Player"); // Resources ���� ��ο� �°� �����ϼ���.

        // �÷��̾� ���� �ʱ�ȭ �Ǵ� �ٸ� ������ ���⿡ �߰�
    }
}
