﻿using System.Threading.Tasks;
using L2ACP.Models;
using L2ACP.Responses;

namespace L2ACP.Services
{
    public interface IRequestService
    {
        Task<L2Response> LoginUser(string username, string password);

        Task<L2Response> RegisterUser(string username, string password);

        Task<L2Response> ChangePassword(string username, string currentPass, string newPass);

        Task<L2Response> GetAccountInfo(string getUsername);

        Task<L2Response> GetInventory(string player);

        Task<L2Response> GetPlayerInfo(string playerName);

        Task<L2Response> EnchantItem(string playerName, int objId, int itemEnch);

        Task<L2Response> SendDonation(string accountName, int amount, string transactionId, string verifySign);

        Task<L2Response> GetBuyList();

        Task<L2Response> BuyItem(string accountName, string modelUsername, int modelItemId, int modelItemCount, int modelEnchant, int modelPrice);

        Task<L2Response> GetTopStats();

        Task<L2Response> GetDonateServices();

        Task<L2Response> RenamePlayer(string playerName, string newName);

        Task<L2Response> SetNobless(string playerName);

        Task<L2Response> ChangeSex(string playerName);

        Task<L2Response> ResetPk(string playerName);
    }
}