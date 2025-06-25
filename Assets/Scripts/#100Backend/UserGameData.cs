﻿[System.Serializable]
public class UserGameData
{
    public int      level;           // Lobby Scene에 보이는 플레이어 레벨
    public float    experience;        // Lobby Scene에 보이는 플레이어 경험치
    public int      gold;            // 무료 재화
    public int      jewel;           // 유료 재화
    public int      heart;           // 게임 플레이에 소모되는 재화
    public int      dailyBestScore;  // 일일 최고 점수

    public void Reset()
    {
        level           = 1;
        experience      = 0;
        gold            = 0;
        jewel           = 0;
        heart           = 30;
        dailyBestScore  = 0;
    }
}

