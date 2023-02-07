using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GolfSweep.Data;
using GolfSweep.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using GolfSweep.Dtos;

namespace GolfSweep.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IPlayerRepository _playerRepository;
        private readonly IRepository<Data.Sweep> _sweepRepository;

        public AccountController(UserManager<ApplicationUser> userManager,
            IPlayerRepository playerRepository,
            IRepository<Data.Sweep> sweepRepository
            )
        {
            _userManager = userManager;
            _playerRepository = playerRepository;
            _sweepRepository = sweepRepository;
        }

        [HttpGet("api/account/getUserAuthDetails")]
        public async Task<IActionResult> GetUserAuthDetails()
        {
            var user = await _userManager.GetUserAsync(User);

            var player = await _playerRepository.GetUserPlayer(user.Id);

            var sweepOwnership = await _sweepRepository.GetWhere(s => s.Owner.Id == user.Id);

            var sweepAdmin = await _playerRepository.GetSweepIdsWherePlayerIsAdmin(player.Id);

            var sweepIds = new List<Guid>();

            foreach (var sweep in sweepOwnership)
            {
                sweepIds.Add(sweep.Id);
            }

            foreach (var sweep in sweepAdmin)
            {
                sweepIds.Add(sweep);
            }

            var userAuthDetails = new UserAuthDetailDto()
            {
                Id = user.Id,
                PlayerId = player.Id,
                SweepIds = sweepIds
            };

            var userAuthDto = new UserAuthDto()
            {
                User = userAuthDetails
            };

            return Ok(userAuthDetails);
        }


        [HttpGet("api/account/getUserPlayerId")]
        public async Task<IActionResult> GetUserPlayerId()
        {
            var user = await _userManager.GetUserAsync(User);

            var player = await _playerRepository.GetUserPlayer(user.Id);

            var dto = new GuidDto()
            {
                Id = player.Id
            };

            return Ok(dto);

        }
    }
}