using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Google.Protobuf;
using UFramework;


namespace FgoDecode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            DataManager dm = new DataManager();


            var iterator = dm.readMasterData();
            while (true)
            {
                Boolean result = iterator.MoveNext();
                if (!result)
                {
                    break;
                }

            }

            if (!Directory.Exists("./fgo"))   
            {
                Directory.CreateDirectory("./fgo");   
            }

            {
                NPC_SVT_FOLLOWER_ARRAY npc_svt_follower_array = NPC_SVT_FOLLOWER_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.NpcSvtFollower.ToByteArray());
                FileStream fs = new FileStream("./fgo/npc_svt_follower_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(npc_svt_follower_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_AI_ACT_ARRAY mst_ai_act_array = MST_AI_ACT_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstAiAct.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_ai_act_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_ai_act_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_AI_ARRAY mst_ai_array = MST_AI_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstAi.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_ai_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_ai_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_AI_FIELD_ARRAY mst_ai_field_array = MST_AI_FIELD_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstAiField.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_ai_field_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_ai_field_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_ATTRI_RELATION_ARRAY mst_attri_relation_array = MST_ATTRI_RELATION_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstAttriRelation.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_attri_relation_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_attri_relation_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_BANK_SHOP_ARRAY mst_bank_shop_array = MST_BANK_SHOP_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstBankShop.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_bank_shop_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_bank_shop_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_BANNER_ARRAY mst_banner_array = MST_BANNER_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstBanner.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_banner_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_banner_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_BATTLE_BG_ARRAY mst_battle_bg_array = MST_BATTLE_BG_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstBattleBg.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_battle_bg_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_battle_bg_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_BGM_ARRAY mst_bgm_array = MST_BGM_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstBgm.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_bgm_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_bgm_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_BOX_GACHA_ARRAY mst_box_gacha_array = MST_BOX_GACHA_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstBoxGacha.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_box_gacha_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_box_gacha_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_BOX_GACHA_BASE_ARRAY mst_box_gacha_base_array = MST_BOX_GACHA_BASE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstBoxGachaBase.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_box_gacha_base_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_box_gacha_base_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_BOX_GACHA_BASE_DETAIL_ARRAY mst_box_gacha_base_detail_array = MST_BOX_GACHA_BASE_DETAIL_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstBoxGachaBaseDetail.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_box_gacha_base_detail_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_box_gacha_base_detail_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_BOX_GACHA_TALK_ARRAY mst_box_gacha_talk_array = MST_BOX_GACHA_TALK_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstBoxGachaTalk.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_box_gacha_talk_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_box_gacha_talk_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_BUFF_ARRAY mst_buff_array = MST_BUFF_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstBuff.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_buff_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_buff_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_CARD_ARRAY mst_card_array = MST_CARD_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstCard.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_card_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_card_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_CLASS_ARRAY mst_class_array = MST_CLASS_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstClass.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_class_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_class_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_CLASS_RELATION_ARRAY mst_class_relation_array = MST_CLASS_RELATION_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstClassRelation.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_class_relation_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_class_relation_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_CLOSED_MESSAGE_ARRAY mst_closed_message_array = MST_CLOSED_MESSAGE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstClosedMessage.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_closed_message_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_closed_message_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_COMBINE_ARRAY mst_combine_array = MST_COMBINE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstCombine.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_combine_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_combine_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_COMBINE_LIMIT_ARRAY mst_combine_limit_array = MST_COMBINE_LIMIT_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstCombineLimit.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_combine_limit_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_combine_limit_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_COMBINE_MATERIAL_ARRAY mst_combine_material_array = MST_COMBINE_MATERIAL_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstCombineMaterial.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_combine_material_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_combine_material_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_COMBINE_QP_ARRAY mst_combine_qp_array = MST_COMBINE_QP_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstCombineQp.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_combine_qp_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_combine_qp_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_COMBINE_QP_SVT_EQUIP_ARRAY mst_combine_qp_svt_equip_array = MST_COMBINE_QP_SVT_EQUIP_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstCombineQpSvtEquip.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_combine_qp_svt_equip_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_combine_qp_svt_equip_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_COMBINE_SKILL_ARRAY mst_combine_skill_array = MST_COMBINE_SKILL_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstCombineSkill.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_combine_skill_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_combine_skill_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_COMMAND_SPELL_ARRAY mst_command_spell_array = MST_COMMAND_SPELL_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstCommandSpell.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_command_spell_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_command_spell_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_CONSTANT_ARRAY mst_constant_array = MST_CONSTANT_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstConstant.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_constant_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_constant_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_CONSTANT_STR_ARRAY mst_constant_str_array = MST_CONSTANT_STR_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstConstantStr.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_constant_str_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_constant_str_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_CV_ARRAY mst_cv_array = MST_CV_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstCv.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_cv_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_cv_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EFFECT_ARRAY mst_effect_array = MST_EFFECT_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEffect.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_effect_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_effect_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EQUIP_ARRAY mst_equip_array = MST_EQUIP_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEquip.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_equip_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_equip_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EQUIP_EXP_ARRAY mst_equip_exp_array = MST_EQUIP_EXP_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEquipExp.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_equip_exp_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_equip_exp_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EQUIP_IMAGE_ARRAY mst_equip_image_array = MST_EQUIP_IMAGE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEquipImage.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_equip_image_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_equip_image_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EQUIP_SKILL_ARRAY mst_equip_skill_array = MST_EQUIP_SKILL_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEquipSkill.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_equip_skill_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_equip_skill_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_ARRAY mst_event_array = MST_EVENT_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEvent.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_CAMPAIGN_ARRAY mst_event_campaign_array = MST_EVENT_CAMPAIGN_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventCampaign.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_campaign_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_campaign_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_DETAIL_ARRAY mst_event_detail_array = MST_EVENT_DETAIL_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventDetail.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_detail_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_detail_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_FILTER_ARRAY mst_event_filter_array = MST_EVENT_FILTER_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventFilter.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_filter_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_filter_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_ITEM_DISPLAY_ARRAY mst_event_item_display_array = MST_EVENT_ITEM_DISPLAY_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventItemDisplay.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_item_display_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_item_display_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_ITEM_DISPLAY_GROUP_ARRAY mst_event_item_display_group_array = MST_EVENT_ITEM_DISPLAY_GROUP_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventItemDisplayGroup.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_item_display_group_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_item_display_group_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_ITEM_DISPLAY_RELEASE_ARRAY mst_event_item_display_release_array = MST_EVENT_ITEM_DISPLAY_RELEASE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventItemDisplayRelease.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_item_display_release_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_item_display_release_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_LOGIN_BONUS_ARRAY mst_event_login_bonus_array = MST_EVENT_LOGIN_BONUS_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventLoginBonus.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_login_bonus_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_login_bonus_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_LOGIN_CAMPAIGN_ARRAY mst_event_login_campaign_array = MST_EVENT_LOGIN_CAMPAIGN_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventLoginCampaign.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_login_campaign_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_login_campaign_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_MISSION_ACTION_ARRAY mst_event_mission_action_array = MST_EVENT_MISSION_ACTION_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventMissionAction.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_mission_action_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_mission_action_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_MISSION_ARRAY mst_event_mission_array = MST_EVENT_MISSION_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventMission.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_mission_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_mission_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_MISSION_CONDITION_ARRAY mst_event_mission_condition_array = MST_EVENT_MISSION_CONDITION_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventMissionCondition.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_mission_condition_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_mission_condition_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_MISSION_CONDITION_DET_ARRAY mst_event_mission_condition_det_array = MST_EVENT_MISSION_CONDITION_DET_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventMissionConditionDet.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_mission_condition_det_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_mission_condition_det_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_QUEST_ARRAY mst_event_quest_array = MST_EVENT_QUEST_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventQuest.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_quest_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_quest_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_REWARD_ARRAY mst_event_reward_array = MST_EVENT_REWARD_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventReward.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_reward_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_reward_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_REWARD_BG_ARRAY mst_event_reward_bg_array = MST_EVENT_REWARD_BG_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventRewardBg.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_reward_bg_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_reward_bg_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_REWARD_SET_ARRAY mst_event_reward_set_array = MST_EVENT_REWARD_SET_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventRewardSet.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_reward_set_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_reward_set_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_SUPER_BOSS_ARRAY mst_event_super_boss_array = MST_EVENT_SUPER_BOSS_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventSuperBoss.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_super_boss_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_super_boss_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_SVT_ARRAY mst_event_svt_array = MST_EVENT_SVT_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventSvt.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_svt_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_svt_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_EVENT_TUTORIAL_ARRAY mst_event_tutorial_array = MST_EVENT_TUTORIAL_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstEventTutorial.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_event_tutorial_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_event_tutorial_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_FRIENDSHIP_ARRAY mst_friendship_array = MST_FRIENDSHIP_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstFriendship.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_friendship_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_friendship_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_FUNC_ARRAY mst_func_array = MST_FUNC_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstFunc.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_func_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_func_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_FUNC_GROUP_ARRAY mst_func_group_array = MST_FUNC_GROUP_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstFuncGroup.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_func_group_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_func_group_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_GACHA_ADJUST_ARRAY mst_gacha_adjust_array = MST_GACHA_ADJUST_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstGachaAdjust.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_gacha_adjust_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_gacha_adjust_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_GACHA_ARRAY mst_gacha_array = MST_GACHA_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstGacha.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_gacha_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_gacha_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_GACHA_BASE_ARRAY mst_gacha_base_array = MST_GACHA_BASE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstGachaBase.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_gacha_base_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_gacha_base_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_GACHA_BONUS_ARRAY mst_gacha_bonus_array = MST_GACHA_BONUS_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstGachaBonus.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_gacha_bonus_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_gacha_bonus_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_GAME_ILLUSTRATION_ARRAY mst_game_illustration_array = MST_GAME_ILLUSTRATION_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstGameIllustration.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_game_illustration_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_game_illustration_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_GIFT_ARRAY mst_gift_array = MST_GIFT_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstGift.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_gift_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_gift_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_GUIDE_ARRAY mst_guide_array = MST_GUIDE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstGuide.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_guide_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_guide_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_HEROINE_ARRAY mst_heroine_array = MST_HEROINE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstHeroine.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_heroine_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_heroine_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_ILLUSTRATOR_ARRAY mst_illustrator_array = MST_ILLUSTRATOR_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstIllustrator.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_illustrator_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_illustrator_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_ITEM_ARRAY mst_item_array = MST_ITEM_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstItem.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_item_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_item_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_MAP_GIMMICK_ARRAY mst_map_gimmick_array = MST_MAP_GIMMICK_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstMapGimmick.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_map_gimmick_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_map_gimmick_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_MASTER_MISSION_ARRAY mst_master_mission_array = MST_MASTER_MISSION_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstMasterMission.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_master_mission_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_master_mission_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_MASTER_MISSION_DISPLAY_INFO_ARRAY mst_master_mission_display_info_array = MST_MASTER_MISSION_DISPLAY_INFO_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstMasterMissionDisplayInfo.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_master_mission_display_info_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_master_mission_display_info_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_MISSION_ARRAY mst_mission_array = MST_MISSION_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstMission.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_mission_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_mission_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_PRESENT_MESSAGE_ARRAY mst_present_message_array = MST_PRESENT_MESSAGE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstPresentMessage.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_present_message_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_present_message_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_QUEST_ARRAY mst_quest_array = MST_QUEST_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstQuest.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_quest_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_quest_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_QUEST_CONSUME_ITEM_ARRAY mst_quest_consume_item_array = MST_QUEST_CONSUME_ITEM_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstQuestConsumeItem.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_quest_consume_item_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_quest_consume_item_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_QUEST_GROUP_ARRAY mst_quest_group_array = MST_QUEST_GROUP_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstQuestGroup.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_quest_group_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_quest_group_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_QUEST_MESSAGE_ARRAY mst_quest_message_array = MST_QUEST_MESSAGE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstQuestMessage.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_quest_message_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_quest_message_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_QUEST_PHASE_ARRAY mst_quest_phase_array = MST_QUEST_PHASE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstQuestPhase.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_quest_phase_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_quest_phase_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_QUEST_PHASE_DETAIL_ARRAY mst_quest_phase_detail_array = MST_QUEST_PHASE_DETAIL_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstQuestPhaseDetail.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_quest_phase_detail_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_quest_phase_detail_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_QUEST_RELEASE_ARRAY mst_quest_release_array = MST_QUEST_RELEASE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstQuestRelease.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_quest_release_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_quest_release_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_QUEST_RESET_ARRAY mst_quest_reset_array = MST_QUEST_RESET_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstQuestReset.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_quest_reset_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_quest_reset_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_QUEST_RESTRICTION_ARRAY mst_quest_restriction_array = MST_QUEST_RESTRICTION_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstQuestRestriction.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_quest_restriction_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_quest_restriction_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_QUEST_SCRIPT_ARRAY mst_quest_script_array = MST_QUEST_SCRIPT_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstQuestScript.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_quest_script_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_quest_script_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_QUEST_SCRIPT_RELEASE_ARRAY mst_quest_script_release_array = MST_QUEST_SCRIPT_RELEASE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstQuestScriptRelease.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_quest_script_release_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_quest_script_release_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_RECOVER_ARRAY mst_recover_array = MST_RECOVER_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstRecover.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_recover_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_recover_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_RESTRICTION_ARRAY mst_restriction_array = MST_RESTRICTION_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstRestriction.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_restriction_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_restriction_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SET_ITEM_ARRAY mst_set_item_array = MST_SET_ITEM_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSetItem.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_set_item_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_set_item_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SHOP_ARRAY mst_shop_array = MST_SHOP_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstShop.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_shop_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_shop_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SHOP_DETAIL_ARRAY mst_shop_detail_array = MST_SHOP_DETAIL_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstShopDetail.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_shop_detail_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_shop_detail_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SHOP_RELEASE_ARRAY mst_shop_release_array = MST_SHOP_RELEASE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstShopRelease.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_shop_release_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_shop_release_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SHOP_SCRIPT_ARRAY mst_shop_script_array = MST_SHOP_SCRIPT_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstShopScript.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_shop_script_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_shop_script_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SKILL_ARRAY mst_skill_array = MST_SKILL_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSkill.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_skill_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_skill_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SKILL_DETAIL_ARRAY mst_skill_detail_array = MST_SKILL_DETAIL_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSkillDetail.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_skill_detail_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_skill_detail_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SKILL_LV_ARRAY mst_skill_lv_array = MST_SKILL_LV_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSkillLv.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_skill_lv_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_skill_lv_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SPOT_ARRAY mst_spot_array = MST_SPOT_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSpot.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_spot_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_spot_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SPOT_IMAGE_ARRAY mst_spot_image_array = MST_SPOT_IMAGE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSpotImage.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_spot_image_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_spot_image_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SPOT_ROAD_ARRAY mst_spot_road_array = MST_SPOT_ROAD_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSpotRoad.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_spot_road_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_spot_road_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_STAGE_ARRAY mst_stage_array = MST_STAGE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstStage.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_stage_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_stage_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_STONE_SHOP_ARRAY mst_stone_shop_array = MST_STONE_SHOP_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstStoneShop.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_stone_shop_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_stone_shop_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_ARRAY mst_svt_array = MST_SVT_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvt.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_CARD_ARRAY mst_svt_card_array = MST_SVT_CARD_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtCard.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_card_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_card_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_COMMENT_ADD_ARRAY mst_svt_comment_add_array = MST_SVT_COMMENT_ADD_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtCommentAdd.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_comment_add_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_comment_add_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_COMMENT_ARRAY mst_svt_comment_array = MST_SVT_COMMENT_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtComment.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_comment_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_comment_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_EXCEED_ARRAY mst_svt_exceed_array = MST_SVT_EXCEED_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtExceed.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_exceed_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_exceed_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_EXP_ARRAY mst_svt_exp_array = MST_SVT_EXP_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtExp.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_exp_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_exp_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_GROUP_ARRAY mst_svt_group_array = MST_SVT_GROUP_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtGroup.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_group_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_group_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_LIMIT_ADD_ARRAY mst_svt_limit_add_array = MST_SVT_LIMIT_ADD_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtLimitAdd.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_limit_add_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_limit_add_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_LIMIT_ARRAY mst_svt_limit_array = MST_SVT_LIMIT_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtLimit.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_limit_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_limit_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_PASSIVE_SKILL_ARRAY mst_svt_passive_skill_array = MST_SVT_PASSIVE_SKILL_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtPassiveSkill.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_passive_skill_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_passive_skill_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_PROFILE_ARRAY mst_svt_profile_array = MST_SVT_PROFILE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtProfile.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_profile_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_profile_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_RARITY_ARRAY mst_svt_rarity_array = MST_SVT_RARITY_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtRarity.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_rarity_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_rarity_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_SCRIPT_ADD_ARRAY mst_svt_script_add_array = MST_SVT_SCRIPT_ADD_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtScriptAdd.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_script_add_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_script_add_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_SCRIPT_ARRAY mst_svt_script_array = MST_SVT_SCRIPT_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtScript.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_script_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_script_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_SKILL_ARRAY mst_svt_skill_array = MST_SVT_SKILL_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtSkill.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_skill_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_skill_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_TREASURE_DEVICE_ARRAY mst_svt_treasure_device_array = MST_SVT_TREASURE_DEVICE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtTreasureDevice.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_treasure_device_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_treasure_device_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_VOICE_ARRAY mst_svt_voice_array = MST_SVT_VOICE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtVoice.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_voice_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_voice_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_SVT_VOICE_RELATION_ARRAY mst_svt_voice_relation_array = MST_SVT_VOICE_RELATION_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstSvtVoiceRelation.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_svt_voice_relation_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_svt_voice_relation_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_TIPS_ARRAY mst_tips_array = MST_TIPS_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstTips.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_tips_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_tips_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_TOTAL_LOGIN_ARRAY mst_total_login_array = MST_TOTAL_LOGIN_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstTotalLogin.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_total_login_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_total_login_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_TREASURE_DEVICE_ARRAY mst_treasure_device_array = MST_TREASURE_DEVICE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstTreasureDevice.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_treasure_device_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_treasure_device_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_TREASURE_DEVICE_DETAIL_ARRAY mst_treasure_device_detail_array = MST_TREASURE_DEVICE_DETAIL_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstTreasureDeviceDetail.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_treasure_device_detail_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_treasure_device_detail_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_TREASURE_DEVICE_LV_ARRAY mst_treasure_device_lv_array = MST_TREASURE_DEVICE_LV_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstTreasureDeviceLv.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_treasure_device_lv_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_treasure_device_lv_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_USER_EXP_ARRAY mst_user_exp_array = MST_USER_EXP_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstUserExp.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_user_exp_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_user_exp_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_USER_TREM_ARRAY mst_user_trem_array = MST_USER_TREM_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstUserTrem.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_user_trem_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_user_trem_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_VOICE_ARRAY mst_voice_array = MST_VOICE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstVoice.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_voice_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_voice_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_VOICE_RELEASE_ARRAY mst_voice_release_array = MST_VOICE_RELEASE_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstVoiceRelease.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_voice_release_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_voice_release_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_WAR_ARRAY mst_war_array = MST_WAR_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstWar.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_war_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_war_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                MST_WAR_BGM_ARRAY mst_war_bgm_array = MST_WAR_BGM_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.MstWarBgm.ToByteArray());
                FileStream fs = new FileStream("./fgo/mst_war_bgm_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(mst_war_bgm_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                NPC_DECK_ARRAY npc_deck_array = NPC_DECK_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.NpcDeck.ToByteArray());
                FileStream fs = new FileStream("./fgo/npc_deck_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(npc_deck_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                NPC_FOLLOWER_ARRAY npc_follower_array = NPC_FOLLOWER_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.NpcFollower.ToByteArray());
                FileStream fs = new FileStream("./fgo/npc_follower_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(npc_follower_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                NPC_SVT_ARRAY npc_svt_array = NPC_SVT_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.NpcSvt.ToByteArray());
                FileStream fs = new FileStream("./fgo/npc_svt_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(npc_svt_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }

            {
                NPC_SVT_DETAIL_ARRAY npc_svt_detail_array = NPC_SVT_DETAIL_ARRAY.Parser.ParseFrom(DataManager.masterDataObject.NpcSvtDetail.ToByteArray());
                FileStream fs = new FileStream("./fgo/npc_svt_detail_array.json", FileMode.Create);
                byte[] data = System.Text.Encoding.Default.GetBytes(npc_svt_detail_array.ToString());
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] array = new string[] {"NPC_SVT_FOLLOWER_ARRAY",
                "MST_AI_ACT_ARRAY",
                "MST_AI_ARRAY",
                "MST_AI_FIELD_ARRAY",
                "MST_ATTRI_RELATION_ARRAY",
                "MST_BANK_SHOP_ARRAY",
                "MST_BANNER_ARRAY",
                "MST_BATTLE_BG_ARRAY",
                "MST_BGM_ARRAY",
                "MST_BOX_GACHA_ARRAY",
                "MST_BOX_GACHA_BASE_ARRAY",
                "MST_BOX_GACHA_BASE_DETAIL_ARRAY",
                "MST_BOX_GACHA_TALK_ARRAY",
                "MST_BUFF_ARRAY",
                "MST_CARD_ARRAY",
                "MST_CLASS_ARRAY",
                "MST_CLASS_RELATION_ARRAY",
                "MST_CLOSED_MESSAGE_ARRAY",
                "MST_COMBINE_ARRAY",
                "MST_COMBINE_LIMIT_ARRAY",
                "MST_COMBINE_MATERIAL_ARRAY",
                "MST_COMBINE_QP_ARRAY",
                "MST_COMBINE_QP_SVT_EQUIP_ARRAY",
                "MST_COMBINE_SKILL_ARRAY",
                "MST_COMMAND_SPELL_ARRAY",
                "MST_CONSTANT_ARRAY",
                "MST_CONSTANT_STR_ARRAY",
                "MST_CV_ARRAY",
                "MST_EFFECT_ARRAY",
                "MST_EQUIP_ARRAY",
                "MST_EQUIP_EXP_ARRAY",
                "MST_EQUIP_IMAGE_ARRAY",
                "MST_EQUIP_SKILL_ARRAY",
                "MST_EVENT_ARRAY",
                "MST_EVENT_CAMPAIGN_ARRAY",
                "MST_EVENT_DETAIL_ARRAY",
                "MST_EVENT_FILTER_ARRAY",
                "MST_EVENT_ITEM_DISPLAY_ARRAY",
                "MST_EVENT_ITEM_DISPLAY_GROUP_ARRAY",
                "MST_EVENT_ITEM_DISPLAY_RELEASE_ARRAY",
                "MST_EVENT_LOGIN_BONUS_ARRAY",
                "MST_EVENT_LOGIN_CAMPAIGN_ARRAY",
                "MST_EVENT_MISSION_ACTION_ARRAY",
                "MST_EVENT_MISSION_ARRAY",
                "MST_EVENT_MISSION_CONDITION_ARRAY",
                "MST_EVENT_MISSION_CONDITION_DET_ARRAY",
                "MST_EVENT_QUEST_ARRAY",
                "MST_EVENT_REWARD_ARRAY",
                "MST_EVENT_REWARD_BG_ARRAY",
                "MST_EVENT_REWARD_SET_ARRAY",
                "MST_EVENT_SUPER_BOSS_ARRAY",
                "MST_EVENT_SVT_ARRAY",
                "MST_EVENT_TUTORIAL_ARRAY",
                "MST_FRIENDSHIP_ARRAY",
                "MST_FUNC_ARRAY",
                "MST_FUNC_GROUP_ARRAY",
                "MST_GACHA_ADJUST_ARRAY",
                "MST_GACHA_ARRAY",
                "MST_GACHA_BASE_ARRAY",
                "MST_GACHA_BONUS_ARRAY",
                "MST_GAME_ILLUSTRATION_ARRAY",
                "MST_GIFT_ARRAY",
                "MST_GUIDE_ARRAY",
                "MST_HEROINE_ARRAY",
                "MST_ILLUSTRATOR_ARRAY",
                "MST_ITEM_ARRAY",
                "MST_MAP_GIMMICK_ARRAY",
                "MST_MASTER_MISSION_ARRAY",
                "MST_MASTER_MISSION_DISPLAY_INFO_ARRAY",
                "MST_MISSION_ARRAY",
                "MST_PRESENT_MESSAGE_ARRAY",
                "MST_QUEST_ARRAY",
                "MST_QUEST_CONSUME_ITEM_ARRAY",
                "MST_QUEST_GROUP_ARRAY",
                "MST_QUEST_MESSAGE_ARRAY",
                "MST_QUEST_PHASE_ARRAY",
                "MST_QUEST_PHASE_DETAIL_ARRAY",
                "MST_QUEST_RELEASE_ARRAY",
                "MST_QUEST_RESET_ARRAY",
                "MST_QUEST_RESTRICTION_ARRAY",
                "MST_QUEST_SCRIPT_ARRAY",
                "MST_QUEST_SCRIPT_RELEASE_ARRAY",
                "MST_RECOVER_ARRAY",
                "MST_RESTRICTION_ARRAY",
                "MST_SET_ITEM_ARRAY",
                "MST_SHOP_ARRAY",
                "MST_SHOP_DETAIL_ARRAY",
                "MST_SHOP_RELEASE_ARRAY",
                "MST_SHOP_SCRIPT_ARRAY",
                "MST_SKILL_ARRAY",
                "MST_SKILL_DETAIL_ARRAY",
                "MST_SKILL_LV_ARRAY",
                "MST_SPOT_ARRAY",
                "MST_SPOT_IMAGE_ARRAY",
                "MST_SPOT_ROAD_ARRAY",
                "MST_STAGE_ARRAY",
                "MST_STONE_SHOP_ARRAY",
                "MST_SVT_ARRAY",
                "MST_SVT_CARD_ARRAY",
                "MST_SVT_COMMENT_ADD_ARRAY",
                "MST_SVT_COMMENT_ARRAY",
                "MST_SVT_EXCEED_ARRAY",
                "MST_SVT_EXP_ARRAY",
                "MST_SVT_GROUP_ARRAY",
                "MST_SVT_LIMIT_ADD_ARRAY",
                "MST_SVT_LIMIT_ARRAY",
                "MST_SVT_PASSIVE_SKILL_ARRAY",
                "MST_SVT_PROFILE_ARRAY",
                "MST_SVT_RARITY_ARRAY",
                "MST_SVT_SCRIPT_ADD_ARRAY",
                "MST_SVT_SCRIPT_ARRAY",
                "MST_SVT_SKILL_ARRAY",
                "MST_SVT_TREASURE_DEVICE_ARRAY",
                "MST_SVT_VOICE_ARRAY",
                "MST_SVT_VOICE_RELATION_ARRAY",
                "MST_TIPS_ARRAY",
                "MST_TOTAL_LOGIN_ARRAY",
                "MST_TREASURE_DEVICE_ARRAY",
                "MST_TREASURE_DEVICE_DETAIL_ARRAY",
                "MST_TREASURE_DEVICE_LV_ARRAY",
                "MST_USER_EXP_ARRAY",
                "MST_USER_TREM_ARRAY",
                "MST_VOICE_ARRAY",
                "MST_VOICE_RELEASE_ARRAY",
                "MST_WAR_ARRAY",
                "MST_WAR_BGM_ARRAY",
                "NPC_DECK_ARRAY",
                "NPC_FOLLOWER_ARRAY",
                "NPC_SVT_ARRAY",
                "NPC_SVT_DETAIL_ARRAY"};

            for (int i = 0; i < array.Length; ++i)
            {
                string str = array[i];
                string[] words = str.Split('_');
                string name1 = str.ToLower();
                string name2 = "";
                for (int j = 0; j < words.Length - 1; ++j)
                {
                    string temp1 = words[j].Substring(0, 1).ToUpper();
                    string temp2 = words[j].Substring(1).ToLower();
                    name2 += temp1 + temp2;
                }
                string result = str + " " + name1 + " = " + str + ".Parser.ParseFrom(DataManager.masterDataObject." + name2 + ".ToByteArray());";
                Console.WriteLine("{");
                Console.WriteLine(result);
                Console.WriteLine("FileStream fs = new FileStream(\"d:\\\\fgo\\\\" + name1 + ".json\", FileMode.Create);");
                Console.WriteLine("byte[] data = System.Text.Encoding.Default.GetBytes(" + name1 + ".ToString());");
                Console.WriteLine("fs.Write(data, 0, data.Length);");
                Console.WriteLine("fs.Flush();");
                Console.WriteLine("fs.Close();");
                Console.WriteLine("}\n");
            }
        }
    }
}
