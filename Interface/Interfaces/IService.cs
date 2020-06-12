using Dacodes.VenadosFC;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Interfaces
{
    public interface IService
    {
        [Get("/api/statistics")]
        [Headers("Accept: Basic")]
        Task<string> GetStadistics([Header("Accept")] string authorization);

        [Get("/api/games")]
        [Headers("Authorization: Basic")]
        Task<string> GetGames([Header("Accept")] string authorization);

        [Get("/api/players")]
        [Headers("Accept: application/json")]
        Task<string> GetPlayers();

        [Get("/api/sponsors")]
        [Headers("Accept: application/json")]
        Task<string> GetSponsors();

        [Get("/api/notifications")]
        [Headers("Accept: application/json")]
        Task<string> GetNotifications();
    }
}
