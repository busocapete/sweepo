using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GolfSweep.Data;
using GolfSweep.Dtos;
using GolfSweep.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sweep.Dtos;

namespace Sweep.Controllers
{
    public class VirtualMatchPlayController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IRepository<Event> _eventRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IPlayerRepository _playerRepository;

        public VirtualMatchPlayController(ApplicationDbContext context,
            IRepository<Event> eventRepository,
            UserManager<ApplicationUser> userManager,
            IPlayerRepository playerRepository
            )
        {
            _context = context;
            _eventRepository = eventRepository;
            _userManager = userManager;
            _playerRepository = playerRepository;
        }


        [HttpGet("api/virtualmatchplay/{id}")]
        public async Task<IActionResult> GetVirtualMatchPlayResults(Guid id)
        {
            var @event = await _eventRepository.GetById(id);
            var user = await _userManager.GetUserAsync(User);
            var userPlayer = await _playerRepository.GetUserPlayer(user.Id);

            var userScoreCard = @event.Entries
                .Where(e => e.ScoreCard.Player.Id == userPlayer.Id)
                .FirstOrDefault();


            var matchResults = new List<MatchResultDto>();

            foreach (var entry in @event.Entries.Where(e => e.ScoreCard.Player.Id != userPlayer.Id))
            {
                var matchScoreCard = entry.ScoreCard;
                var course = entry.ScoreCard.Course;

                var userHandicap = userScoreCard.ScoreCard.EventHandicap;
                var againstHandicap = entry.ScoreCard.EventHandicap;

                var userShots = 0;
                var againstShots = 0;

                if (userHandicap < againstHandicap)
                {
                    againstShots = againstHandicap - userHandicap;
                }

                if (userHandicap > againstHandicap)
                {
                    userShots = userHandicap - againstHandicap;
                }

                

                int matchResult = 0;

                //matchScoreCard.Scores = matchScoreCard.Scores.OrderBy(h => h.HoleNumber).ToList();

                for (int i = 0; i < matchScoreCard.Scores.Count(); i++)
                {
                    var score = matchScoreCard.Scores.Where(h => h.HoleNumber == i + 1).FirstOrDefault();
                    var userScore = userScoreCard.ScoreCard.Scores.Where(s => s.HoleNumber == score.HoleNumber).Select(h => h.Gross).FirstOrDefault();
                    var againstScore = score.Gross;
                    var holeIndex = course.Holes.Where(h => h.Number == score.HoleNumber).Select(h => h.Index).FirstOrDefault();

                    var holesLeft = 18 - score.HoleNumber;

                    if (againstScore == 0 && userScore > 0)
                    {
                        matchResult++;
                    } else if (userScore == 0 && againstScore > 0)
                    {
                        matchResult--;
                    } 

                    else if (userHandicap > againstHandicap)
                    {

                        if (holeIndex <= userShots)
                        {
                            userScore = userScore - 1;
                        }


                        if (userScore < againstScore)
                        {
                            matchResult++;
                        }

                        if (userScore > againstScore)
                        {
                            matchResult--;
                        }
                    } else if (userHandicap < againstHandicap)
                    {
                        if (holeIndex <= againstShots)
                        {
                            againstScore = againstScore - 1;
                        }

                        if (userScore < againstScore)
                        {
                            matchResult++;
                        }
                        if (userScore > againstScore)
                        {
                            matchResult--;
                        }
                    }

                    if (Math.Abs(matchResult) > holesLeft)
                    {
                        if (matchResult > 0)
                        {
                            if (!matchResults.Any(r => r.PlayerName == entry.ScoreCard.Player.FullName))
                            {
                                var matchResultToAdd = new MatchResultDto()
                                {
                                    PlayerName = entry.ScoreCard.Player.FullName,
                                    Won = true,
                                    MatchResult = Math.Abs(matchResult),
                                    Hole = score.HoleNumber

                                };

                                matchResults.Add(matchResultToAdd);
                                i++;
                            }
                        }
                        else
                        {
                            if (!matchResults.Any(r => r.PlayerName == entry.ScoreCard.Player.FullName))
                            {

                                var matchResultToAdd = new MatchResultDto()
                                {
                                    PlayerName = entry.ScoreCard.Player.FullName,
                                    Won = false,
                                    MatchResult = Math.Abs(matchResult),
                                    Hole = score.HoleNumber
                                };

                                matchResults.Add(matchResultToAdd);
                                i++;
                            }
                        }
                    }

                    if (holesLeft == 0)
                    {
                        if (matchResult == 0)
                        {
                            if (!matchResults.Any(r => r.PlayerName == entry.ScoreCard.Player.FullName))
                            {

                                var matchResultToAdd = new MatchResultDto()
                                {
                                    PlayerName = entry.ScoreCard.Player.FullName,
                                    Won = false,
                                    Halved = true,                                    
                                    MatchResult = matchResult,
                                    Hole = score.HoleNumber

                                };

                                matchResults.Add(matchResultToAdd);
                                i++;
                            }
                        }
                    }


                }


            }


            var eventToReturn = AutoMapper.Mapper.Map<EventDto>(@event);

            eventToReturn.Results = matchResults;

            return Ok(eventToReturn);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}