using UnityEngine;
using TMPro;

public class Friend : FriendBase
{
	[SerializeField]
	private	TextMeshProUGUI	textLevel;

	public override void Setup(BackendFriendSystem friendSystem, FriendPageBase friendPage, FriendData friendData)
	{
		base.Setup(friendSystem, friendPage, friendData);

		textLevel.text	= friendData.level;
		textTime.text	= System.DateTime.Parse(friendData.lastLogin).ToString();
	}

	public void OnClickDeleteFriend()
	{
		// 친구 UI 오브젝트 삭제
		friendPage.Deactivate(gameObject);
		// 친구 삭제 (Backend Console)
		backendFriendSystem.BreakFriend(friendData);
	}
}

