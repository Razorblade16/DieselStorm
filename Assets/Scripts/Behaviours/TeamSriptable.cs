﻿using System.Collections;
using System.Collections.Generic;
using Prototype.NetworkLobby;
using UnityEngine;
using UnityEngine.Networking;

[CreateAssetMenu(menuName = "TeamScriptable")]
public class TeamSriptable : ScriptableObject
{
    public List<PlayerBehaviour> m_Players;
    public GameEventArgs m_OnPlayerAdded;
    [SerializeField]
    private Color m_Color;

    public NetworkLobbyManager m_LobbyManager;

    void OnEnable()
    {
        m_Players = new List<PlayerBehaviour>();
    }

    public Color Color
    {
        get { return m_Color; }
    }
    
    public void AddPlayer(PlayerBehaviour player)
    {        
        if(!m_Players.Contains(player))
            m_Players.Add(player);
    }

    public void RemovePlayer(PlayerBehaviour player)
    {
        if(m_Players.Contains(player))
            m_Players.Remove(player);
    }
}