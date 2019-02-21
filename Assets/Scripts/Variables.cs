﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Variables
{
    public static Dictionary<string, ConstelData> Constels;     // 별자리에 대한 데이터
    public static Dictionary<int, CharacterData> Characters;    // 캐릭터에 대한 데이터

    public static readonly int[] FavorityThreshold = { 30, 70, 120, 180, 250 };     // 캐릭터 호감도 문턱에 관한 배열

    #region Variables for dialogue scene
    public static int DialogCharIndex;          // 대화 씬에서 참조할 캐릭터 번호
    public static int DialogCardIndex;          // 대화 씬에서 참조할 캐릭터 내 종류 번호
    public static int DialogChapterIndex;       // 대화 씬에서 참조할 해당 캐릭터 종류의 스토리 번호
    public static string DialogAfterScene;      // 대화 씬이 종료된 다음 씬의 이름
    #endregion
}