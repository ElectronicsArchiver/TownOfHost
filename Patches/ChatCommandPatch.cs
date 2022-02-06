using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using Hazel;
using System;
using HarmonyLib;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnhollowerBaseLib;
using TownOfHost;
using System.Threading.Tasks;
using System.Threading;

namespace TownOfHost
{
    [HarmonyPatch(typeof(ChatController), nameof(ChatController.SendChat))]
    class ChatCommands
    {
        public static bool Prefix(ChatController __instance)
        {
            var text = __instance.TextArea.text;
            string[] args = text.Split(' ');
            var canceled = false;
            var cancelVal = "";
            if (AmongUsClient.Instance.AmHost)
            {
                switch(args[0])
                {
                    case "/win":
                    case "/winner":
                        canceled = true;
                        main.SendToAll(main.winnerList);
                        break;
                    
                    case "/r":
                    case "/rename":
                        canceled = true;
                        main.nickName = args[1];
                        break;
                    
                    case "/n":
                    case "/now":
                        canceled = true;
                        main.ShowActiveSettings();
                        break;
                    
                    case "/dis":
                        canceled = true;
                        if(args.Length < 2){__instance.AddChat(PlayerControl.LocalPlayer, "crewmate | impostor");cancelVal = "/dis";}
                        switch(args[1]){
                            case "crewmate":
                                ShipStatus.Instance.enabled = false;
                                ShipStatus.RpcEndGame(GameOverReason.HumansDisconnect, false);
                                break;

                            case "impostor":
                                ShipStatus.Instance.enabled = false;
                                ShipStatus.RpcEndGame(GameOverReason.ImpostorDisconnect, false);
                                break;

                            default:
                                __instance.AddChat(PlayerControl.LocalPlayer, "crewmate | impostor");
                                cancelVal = "/dis";
                                break;
                        }
                        ShipStatus.Instance.RpcRepairSystem(SystemTypes.Admin, 0);
                        break;
                    
                    case "/h":
                    case "/help":
                        canceled = true;
                        if(args.Length < 2)
                        {
                            main.ShowHelp();
                            break;
                        }
                        switch (args[1])
                        {
                            case "r":
                            case "roles":
                                if(args.Length < 3){getRolesInfo("");break;}
                                getRolesInfo(args[2]);
                                break;

                            case "m":
                            case "modes":
                                if(args.Length < 3){main.SendToAll("使用可能な引数(略称): hideandseek(has), nogameend(nge), syncbuttonmode(sbm)");break;}
                                switch (args[2])
                                {
                                    case "hideandseek":
                                    case "has":
                                        main.SendToAll(main.getLang(lang.HideAndSeekInfo));
                                        break;

                                    case "nogameend":
                                    case "nge":
                                        main.SendToAll(main.getLang(lang.NoGameEndInfo));
                                        break;

                                    case "syncbuttonmode":
                                    case "sbm":
                                        main.SendToAll(main.getLang(lang.SyncButtonModeInfo));
                                        break;
                                    
                                    default:
                                        main.SendToAll("使用可能な引数(略称): hideandseek(has), nogameend(nge), syncbuttonmode(sbm)");
                                        break;
                                }
                                break;

                            default:
                                main.ShowHelp();
                                break;
                            }
                            break;

                    default:
                        break;
                }
            }
            if (canceled)
            {
                Logger.info("Command Canceled");
                __instance.TextArea.Clear();
                __instance.TextArea.SetText(cancelVal);
                __instance.quickChatMenu.ResetGlyphs();
            }
            return !canceled;
        }

        public static void getRolesInfo(string role)
        {
            switch (role)
            {
                case "jester":
                case "je":
                    main.SendToAll(main.getLang(lang.JesterInfoLong));
                    break;
                    
                case "madmate":
                case "ma":
                    main.SendToAll(main.getLang(lang.MadmateInfoLong));
                    break;
                    
                case "bait":
                case "ba":
                    main.SendToAll(main.getLang(lang.BaitInfoLong));
                    break;
                    
                case "terrorist":
                case "te":
                    main.SendToAll(main.getLang(lang.TerroristInfoLong));
                    break;
                    
                case "mafia":
                case "maf":
                    main.SendToAll(main.getLang(lang.MafiaInfoLong));
                    break;
                    
                case "vampire":
                case "va":
                    main.SendToAll(main.getLang(lang.VampireInfoLong));
                    break;
                    
                case "sabotagemaster":
                case "sa":
                    main.SendToAll(main.getLang(lang.SabotageMasterInfoLong));
                    break;
                    
                case "mayor":
                case "may":
                    main.SendToAll(main.getLang(lang.MayorInfoLong));
                    break;
                    
                case "madguardian":
                case "mad":
                    main.SendToAll(main.getLang(lang.MadGuardianInfoLong));
                    break;
                    
                case "opportunist":
                case "op":
                    main.SendToAll(main.getLang(lang.OpportunistInfoLong));
                    break;
                    
                case "snitch":
                case "sn":
                    main.SendToAll(main.getLang(lang.SnitchInfoLong));
                    break;
                    
                case "darkscientist":
                case "da":
                    main.SendToAll(main.getLang(lang.DarkScientistInfoLong));
                    break;

                case "fox":
                case "fo":
                    main.SendToAll(main.getLang(lang.FoxInfoLong));
                    break;
                    
                case "troll":
                case "tr":
                    main.SendToAll(main.getLang(lang.TrollInfoLong));
                    break;

                default:
                    main.SendToAll("使用可能な引数(略称): jester(je), madmate(ma), bait(ba), terrorist(te), sidekick(si), vampire(va),\n sabotagemaster(sa), mayor(may), madguardian(mad), opportunist(op), snitch(sn), darkScientist(da)fox(fo), troll(tr)");
                    break;
            }

        }
        public static bool getCommand(string command, string text, out string arg)
        {
            arg = "";
            var isValid = text.StartsWith(command + " ");
            if (isValid)
                arg = text.Substring(command.Length + 1);
            if (text == command) isValid = true;
            return isValid;
        }
        public static string CommandReturn(lang prefixID, lang textID)
        {
            var text = "";
            text = main.getLang(prefixID);
            return text.Replace("%1$", main.getLang(textID));
        }
        public static string getOnOff(bool value)
        {
            if (value) return main.getLang(lang.ON);
            else return main.getLang(lang.OFF);
        }
    }
    [HarmonyPatch(typeof(ChatController), nameof(ChatController.Update))]
    class ChatUpdatePatch
    {
        public static void Postfix(ChatController __instance)
        {
            if (!AmongUsClient.Instance.AmHost) return;
            float num = 3f - __instance.TimeSinceLastMessage;
            if (main.MessagesToSend.Count > 0 && num <= 0.0f)
            {
                string msg = main.MessagesToSend[0];
                main.MessagesToSend.RemoveAt(0);
                __instance.TimeSinceLastMessage = 0.0f;
                PlayerControl.LocalPlayer.RpcSendChat(msg);
            }
        }
    }
}
