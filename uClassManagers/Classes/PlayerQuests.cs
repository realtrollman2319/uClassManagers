using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using uClassManagers.Classes.Assets;
using uScript.API.Attributes;
using uScript.Core;
using uScript.Module.Main.Classes;

namespace uClassManagers.Classes
{
    [ScriptClass("PlayerQuests")]
    public class PlayerQuestsClass
    {
        public PlayerQuests playerQuests { get; private set; }
        public PlayerQuestsClass(PlayerQuests c_PlayerQuests) => playerQuests = c_PlayerQuests;

        [ScriptProperty("SAVEDATA_VERSION")]
        public static byte SAVEDATA_VERSION => PlayerQuests.SAVEDATA_VERSION;

        [ScriptProperty("DEFAULT_RADIO_FREQUENCY")]
        public static uint DEFAULT_RADIO_FREQUENCY => PlayerQuests.DEFAULT_RADIO_FREQUENCY;

        [ScriptProperty("npcSpawnId")]
        public string NpcSpawnId => playerQuests.npcSpawnId;

        [ScriptProperty("groupID")]
        public string GroupID => playerQuests.groupID.m_SteamID.ToString();

        [ScriptProperty("radioFrequency")]
        public uint RadioFrequency => playerQuests.radioFrequency;

        [ScriptProperty("markerTextOverride")]
        public string MarkerTextOverride => playerQuests.markerTextOverride;

        [ScriptProperty("isMarkerPlaced")]
        public bool IsMarkerPlaced => playerQuests.isMarkerPlaced;

        [ScriptProperty("questsList")]
        public ExpressionValue QuestsList
        {
            get
            {
                List<ExpressionValue> list = new List<ExpressionValue>();
                foreach (PlayerQuest quest in playerQuests.questsList)
                {
                    list.Add(ExpressionValue.CreateObject(new PlayerQuestClass(quest)));
                }
                return ExpressionValue.Array(list.ToArray());
            }
        }

        [ScriptProperty("groupRank")]
        public string GroupRank => playerQuests.groupRank.ToString();

        [ScriptProperty("flagsList")]
        public ExpressionValue FlagsList
        {
            get
            {
                List<ExpressionValue> list = new List<ExpressionValue>();
                foreach (PlayerQuestFlag questFlag in playerQuests.flagsList)
                {
                    list.Add(ExpressionValue.CreateObject(new PlayerQuestFlagClass(questFlag)));
                }
                return ExpressionValue.Array(list.ToArray());
            }
        }

        [ScriptProperty("markerPosition")]
        public Vector3Class MarkerPosition => new Vector3Class(playerQuests.markerPosition);

        [ScriptProperty("groupInvites")]
        public ExpressionValue GroupInvites
        {
            get
            {
                List<ExpressionValue> list = new List<ExpressionValue>();
                CSteamID[] steamIdList = playerQuests.groupInvites.ToArray();
                foreach (CSteamID id in steamIdList)
                {
                    list.Add(id.m_SteamID.ToString());
                }
                return ExpressionValue.Array(list.ToArray());
            }
        }

        [ScriptProperty("hasPermissionToChangeRank")]
        public bool HasPermissionToChangeRank => playerQuests.hasPermissionToChangeRank;

        [ScriptProperty("hasSpaceForMoreMembersInGroup")]
        public bool HasSpaceForMoreMembersInGroup => playerQuests.hasSpaceForMoreMembersInGroup;

        [ScriptProperty("canChangeGroupMembership")]
        public bool CanChangeGroupMembership => playerQuests.canChangeGroupMembership;

        [ScriptProperty("hasPermissionToChangeName")]
        public bool HasPermissionToChangeName => playerQuests.hasPermissionToChangeName;

        [ScriptProperty("hasPermissionToInviteMembers")]
        public bool HasPermissionToInviteMembers => playerQuests.hasPermissionToInviteMembers;

        [ScriptProperty("hasPermissionToKickMembers")]
        public bool HasPermissionToKickMembers => playerQuests.hasPermissionToKickMembers;

        [ScriptProperty("hasPermissionToCreateGroup")]
        public bool HasPermissionToCreateGroup => playerQuests.hasPermissionToCreateGroup;

        [ScriptProperty("hasPermissionToLeaveGroup")]
        public bool HasPermissionToLeaveGroup => playerQuests.hasPermissionToLeaveGroup;

        [ScriptProperty("hasPermissionToDeleteGroup")]
        public bool HasPermissionToDeleteGroup => playerQuests.hasPermissionToDeleteGroup;

        [ScriptProperty("canBeKickedFromGroup")]
        public bool CanBeKickedFromGroup => playerQuests.canBeKickedFromGroup;

        [ScriptProperty("isMemberOfAGroup")]
        public bool IsMemberOfAGroup => playerQuests.isMemberOfAGroup;

        [ScriptProperty("useMaxGroupMembersLimit")]
        public bool UseMaxGroupMembersLimit => playerQuests.useMaxGroupMembersLimit;

        [ScriptFunction("AddQuest")]
        public void AddQuest(QuestAssetClass questAsset)
        {
            playerQuests.AddQuest(questAsset.questAsset);
        }

        [ScriptFunction("changeRank")]
        public void ChangeRank(string newRank)
        {
            EPlayerGroupRank? rank = EnumTool.playerGroupRanks.GetEnum(newRank);
            if (rank == null) return;
            playerQuests.changeRank(rank.Value);
        }

        [ScriptFunction("ClientAbandonQuest")]
        public void ClientAbandonQuest(QuestAssetClass questAsset)
        {
            playerQuests.ClientAbandonQuest(questAsset.questAsset);
        }

        [ScriptFunction("ClientChooseDialogueResponse")]
        public void ClientChooseDialogueResponse(string assetGuid, byte index)
        {
            playerQuests.ClientChooseDialogueResponse(GuidTool.ParseGuid(assetGuid), index);
        }

        [ScriptFunction("ClientChooseNextDialogue")]
        public void ClientChooseNextDialogue(string assetGuid, byte index)
        {
            playerQuests.ClientChooseNextDialogue(GuidTool.ParseGuid(assetGuid), index);
        }

        [ScriptFunction("ClientTrackQuest")]
        public void ClientTrackQuest(QuestAssetClass questAsset)
        {
            playerQuests.ClientTrackQuest(questAsset.questAsset);
        }

        [ScriptFunction("CompleteQuest")]
        public void CompleteQuest(QuestAssetClass questAsset, bool ignoreNPC = false)
        {
            playerQuests.CompleteQuest(questAsset.questAsset, ignoreNPC);
        }

        [ScriptFunction("countValidQuests")]
        public int CountValidQuests()
        {
            return playerQuests.countValidQuests();
        }

        [ScriptFunction("deleteGroup")]
        public void DeleteGroup()
        {
            playerQuests.deleteGroup();
        }

        [ScriptFunction("getFlag")]
        public bool GetFlag(ushort id)
        {
            bool hasFound = playerQuests.getFlag(id, out short value);
            List<ExpressionValue> list = new List<ExpressionValue>()
            { hasFound, value };
            return ExpressionValue.Array(list.ToArray());
        }

        [ScriptFunction("GetQuestStatus")]
        public string GetQuestStatus(QuestAssetClass questAsset)
        {
            return playerQuests.GetQuestStatus(questAsset.questAsset).ToString();
        }

        [ScriptFunction("GetTrackedQuest")]
        public QuestAssetClass GetTrackedQuest()
        {
            return new QuestAssetClass(playerQuests.GetTrackedQuest());
        }

        [ScriptFunction("isMemberOfGroup")]
        public bool IsMemberOfGroup(string groupID)
        {
            return playerQuests.isMemberOfGroup(new CSteamID(ulong.Parse(groupID)));
        }

        [ScriptFunction("isMemberOfSameGroupAs")]
        public bool IsMemberOfSameGroupAs(PlayerClass player)
        {
            return playerQuests.isMemberOfSameGroupAs(player.Player);
        }

        [ScriptFunction("leaveGroup")]
        public void LeaveGroup(bool force = false)
        {
            playerQuests.leaveGroup(force);
        }

        [ScriptFunction("load")]
        public void Load()
        {
            playerQuests.load();
        }

        [ScriptFunction("removeFlag")]
        public void RemoveFlag(ushort id)
        {
            playerQuests.removeFlag(id);
        }

        [ScriptFunction("RemoveQuest")]
        public void RemoveQuest(QuestAssetClass questAsset, bool wasCompleted = false)
        {
            playerQuests.RemoveQuest(questAsset.questAsset, wasCompleted);
        }

        [ScriptFunction("replicateSetMarker")]
        public void ReplicateSetMarker(bool newIsMarkerPlaced, Vector3Class newMarkerPosition, string newMarkerTextOverride = "")
        {
            playerQuests.replicateSetMarker(newIsMarkerPlaced, newMarkerPosition.Vector3, newMarkerTextOverride);
        }

        [ScriptFunction("save")]
        public void Save()
        {
            playerQuests.save();
        }

        [ScriptFunction("SendAcceptGroupInvitation")]
        public void SendAcceptGroupInvitation(string newGroupID)
        {
            playerQuests.SendAcceptGroupInvitation(new CSteamID(ulong.Parse(newGroupID)));
        }

        [ScriptFunction("sendAddGroupInvite")]
        public void SendAddGroupInvite(string newGroupID)
        {
            playerQuests.sendAddGroupInvite(new CSteamID(ulong.Parse(newGroupID)));
        }

        [ScriptFunction("sendAskAddGroupInvite")]
        public void SendAskAddGroupInvite(string targetID)
        {
            playerQuests.sendAskAddGroupInvite(new CSteamID(ulong.Parse(targetID)));
        }

        [ScriptFunction("sendBuyFromVendor")]
        public void SendBuyFromVendor(string assetGuid, byte index, bool asManyAsPossible)
        {
            playerQuests.sendBuyFromVendor(GuidTool.ParseGuid(assetGuid), index, asManyAsPossible);
        }

        [ScriptFunction("sendCreateGroup")]
        public void SendCreateGroup()
        {
            playerQuests.sendCreateGroup();
        }

        [ScriptFunction("SendDeclineGroupInvitation")]
        public void SendDeclineGroupInvitation(string newGroupID)
        {
            playerQuests.SendDeclineGroupInvitation(new CSteamID(ulong.Parse(newGroupID)));
        }

        [ScriptFunction("sendDeleteGroup")]
        public void SendDeleteGroup()
        {
            playerQuests.sendDeleteGroup();
        }

        [ScriptFunction("sendDemote")]
        public void SendDemote(string targetID)
        {
            playerQuests.sendDemote(new CSteamID(ulong.Parse(targetID)));
        }

        [ScriptFunction("sendKickFromGroup")]
        public void SendKickFromGroup(string targetID)
        {
            playerQuests.sendKickFromGroup(new CSteamID(ulong.Parse(targetID)));
        }

        [ScriptFunction("sendLeaveGroup")]
        public void SendLeaveGroup()
        {
            playerQuests.sendLeaveGroup();
        }

        [ScriptFunction("sendPromote")]
        public void SendPromote(string targetID)
        {
            playerQuests.sendPromote(new CSteamID(ulong.Parse(targetID)));
        }

        [ScriptFunction("sendRemoveFlag")]
        public void SendRemoveFlag(ushort id)
        {
            playerQuests.sendRemoveFlag(id);
        }

        [ScriptFunction("sendRenameGroup")]
        public void SendRenameGroup(string newName)
        {
            playerQuests.sendRenameGroup(newName);
        }

        [ScriptFunction("sendSellToVendor")]
        public void SendSellToVendor(string assetGuid, byte index, bool asManyAsPossible)
        {
            playerQuests.sendSellToVendor(GuidTool.ParseGuid(assetGuid), index, asManyAsPossible);
        }

        [ScriptFunction("sendSetFlag")]
        public void SendSetFlag(ushort id, short value)
        {
            playerQuests.sendSetFlag(id, value);
        }

        [ScriptFunction("sendSetMarker")]
        public void SendSetMarker(bool newIsMarkerPlaced, Vector3Class newMarkerPosition)
        {
            playerQuests.sendSetMarker(newIsMarkerPlaced, newMarkerPosition.Vector3);
        }

        [ScriptFunction("sendSetRadioFrequency")]
        public void SendSetRadioFrequency(uint newRadioFrequency)
        {
            playerQuests.sendSetRadioFrequency(newRadioFrequency);
        }

        [ScriptFunction("ServerAddQuest")]
        public void ServerAddQuest(QuestAssetClass questAsset)
        {
            playerQuests.ServerAddQuest(questAsset.questAsset);
        }

        [ScriptFunction("ServerAssignToGroup")]
        public bool ServerAssignToGroup(string newGroupID, string newRank, bool bypassMemberLimit)
        {
            EPlayerGroupRank? rank = EnumTool.playerGroupRanks.GetEnum(newRank);
            if (rank == null) return false;
            return playerQuests.ServerAssignToGroup(new CSteamID(ulong.Parse(newGroupID)), rank.Value, bypassMemberLimit);
        }

        [ScriptFunction("ServerAssignToMainGroup")]
        public void ServerAssignToMainGroup()
        {
            playerQuests.ServerAssignToMainGroup();
        }

        [ScriptFunction("ServerRemoveGroupInvitation")]
        public bool ServerRemoveGroupInvitation(string groupId)
        {
            return playerQuests.ServerRemoveGroupInvitation(new CSteamID(ulong.Parse(groupId)));
        }

        [ScriptFunction("ServerRemoveQuest")]
        public void ServerRemoveQuest(QuestAssetClass questAsset, bool wasCompleted = false)
        {
            playerQuests.ServerRemoveQuest(questAsset.questAsset, wasCompleted);
        }

        [ScriptFunction("ServerRemoveQuest")]
        public void ServerRemoveQuest(QuestAssetClass questAsset)
        {
            playerQuests.ServerRemoveQuest(questAsset.questAsset);
        }

        [ScriptFunction("setFlag")]
        public void SetFlag(ushort id, short value)
        {
            playerQuests.setFlag(id, value);
        }

        [ScriptFunction("trackAnimalKill")]
        public void TrackAnimalKill(uAnimalClass animal)
        {
            playerQuests.trackAnimalKill(animal.animal);
        }

        [ScriptFunction("trackHordeKill")]
        public void TrackHordeKill()
        {
            playerQuests.trackHordeKill();
        }

        [ScriptFunction("trackObjectKill")]
        public void TrackObjectKill(string objectGuid, byte nav)
        {
            playerQuests.trackObjectKill(GuidTool.ParseGuid(objectGuid), nav);
        }

        [ScriptFunction("trackPlayerKill")]
        public void TrackPlayerKill(PlayerClass enemyPlayer)
        {
            playerQuests.trackPlayerKill(enemyPlayer.Player);
        }

        [ScriptFunction("TrackQuest")]
        public void TrackQuest(QuestAssetClass questAsset)
        {
            playerQuests.TrackQuest(questAsset.questAsset);
        }

        [ScriptFunction("trackTreeKill")]
        public void TrackTreeKill(string treeGuid)
        {
            playerQuests.trackTreeKill(GuidTool.ParseGuid(treeGuid));
        }

        [ScriptFunction("trackZombieKill")]
        public void TrackZombieKill(uZombieClass zombie)
        {
            playerQuests.trackZombieKill(zombie.zombie);
        }
    }
}