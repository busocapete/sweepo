using AutoMapper;
using GolfSweep.Data;
using GolfSweep.Dtos;
using GolfSweep.Models;
using GolfSweep.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Controllers
{
    public class ScoreCardsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IScoreCardRepository _repository;
        private readonly IRepository<Player> _playerRepository;
        private readonly IScoreRepository _scoreRepository;

        public ScoreCardsController(ApplicationDbContext context,
            IScoreCardRepository repository,
            IRepository<Player> playerRepository,
            IScoreRepository scoreRepository)
        {
            _context = context;
            _repository = repository;
            _playerRepository = playerRepository;
            _scoreRepository = scoreRepository;
        }


        [Route("api/scorecards/{id}")]
        public async Task<IActionResult> GetScoreCard(Guid id)
        {
            if (id == null)
                return NotFound();

            var scoreCard = await _repository.GetById(id);

            if (scoreCard == null)
                return NotFound();

            //var course = _context.Events
            //    .Where(e => e.Entries.Any(ev => ev.ScoreCard.Id == id))
            //    .Select(e => e.Course).FirstOrDefault();

            var course = await _repository.GetCourseForScoreCard(id);

            //var eventId = _context.Events.Where(e => e.Entries.Any(ev => ev.ScoreCard.Id == id))
            //    .Select(e => e.Id).FirstOrDefault();

            var eventId = await _repository.GetEventIdForScoreCard(id);

            var scoreCardToReturn = Mapper.Map<ScoreCardDto>(scoreCard);

            foreach (var score in scoreCardToReturn.Scores.OrderBy(h => h.HoleNumber))
            {
                var hole = course.Holes.Where(h => h.Number == score.HoleNumber).FirstOrDefault();
                score.Par = hole.Par;
                score.Index = hole.Index;
            }

            scoreCardToReturn.CourseName = course.Name;
            scoreCardToReturn.Course = Mapper.Map<CourseDto>(course);
            scoreCardToReturn.EventId = eventId;

            scoreCardToReturn.Scores.OrderBy(s => s.HoleNumber);

            var scoresToReturn = Mapper.Map<IEnumerable<ScoreDto>>(scoreCardToReturn.Scores).ToList();

            scoreCardToReturn.Scores = scoresToReturn;
            scoreCardToReturn.Scores = scoreCardToReturn.Scores.OrderBy(h => h.HoleNumber).ToList();

            return Ok(scoreCardToReturn);
        }

        // GET: ScoreCards
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ScoreCards.Include(s => s.Player);
            return View(await applicationDbContext.ToListAsync());
        }

        [Route("Players/{playerId}/Scorecards/{id}")]
        public async Task<IActionResult> EntryCard(Guid id, Guid playerId)
        {
            if (id == null)
            {
                return NotFound();
            }
            var scoreCard = await _repository.GetById(id);

            if (scoreCard == null)
            {
                return NotFound();
            }

            var dto = _repository.CreatePlayerCardDto(scoreCard);

            return View(dto);
        }

        // GET: ScoreCards/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var scoreCard = await _context.ScoreCards
            //    .Include(s => s.Player)
            //    .FirstOrDefaultAsync(m => m.Id == id);

            var scoreCard = await _repository.GetById(id.Value);

            //var firstNett = scoreCard.First;

            if (scoreCard == null)
            {
                return NotFound();
            }

            return View(scoreCard);
        }

        // GET: ScoreCards/Create
        public IActionResult Create(Guid PlayerId)
        {
            ViewData["PlayerId"] = new SelectList(_context.Players, "Id", "Id");
            return View();
        }

        public static int CalculatePoints(int nettScore, int par)
        {
            var points = 0;

            if (nettScore == 0)
            {
                return points;
            }

            if (nettScore == (par - 1))
            {
                points = 3;
            }
            else if (nettScore == (par - 2))
            {
                points = 4;
            }
            else if (nettScore == (par - 3))
            {
                points = 5;
            }
            else if (nettScore == par)
            {
                points = 2;
            }
            else if (nettScore == (par + 1))
            {
                points = 1;
            }
            else
            {
                points = 0;
            }

            return points;

        }

        public static int CalculateNettScore(int gross, Hole hole, int eventHandicap)
        {
            var nettScore = gross;

            if (gross == 0)
            {
                nettScore = 0;
                return nettScore;
            }

            var handicap = eventHandicap;
            var index = hole.Index;

            if (handicap <= 18)
            {
                if (index <= handicap)
                {
                    nettScore = gross - 1;
                }
            }

            if (handicap > 18)
            {
                var extraShots = handicap - 18;

                if (index <= extraShots)
                {
                    nettScore = gross - 2;
                }
                else
                {
                    nettScore = gross - 1;
                }
            }

            return nettScore;
        }

        // POST: ScoreCards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Guid playerId, [Bind("First,Second,Third,Fourth,Fifth,Sixth,Seventh,Eighth,Ninth,Tenth,Eleventh,Twelwth,Thirteenth,Fourteenth,Fifteenth,Sixteenth,Seventeenth,Eithteenth,PlayerId,Id,Created")] ScoreCard scoreCard)
        {
            if (ModelState.IsValid)
            {
                scoreCard.Id = Guid.NewGuid();

                //scoreCard.FirstNett = scoreCard.First;
                //var player = _context.Players.Where(p => p.Id == playerId).FirstOrDefault();
                //var firstHole = scoreCard.Course.Holes.Where(h => h.Number == 1)
                //    .FirstOrDefault();

                //if (firstHole.Index >= player.CurrentHandicap)
                //{
                //    scoreCard.FirstNett = scoreCard.First - 1;
                //}

                //scoreCard.FirstPoints = CalculatePoints(scoreCard.FirstNett, firstHole.Par);

                _context.Add(scoreCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlayerId"] = new SelectList(_context.Players, "Id", "Id", scoreCard.PlayerId);
            return View(scoreCard);
        }

        // GET: ScoreCards/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scoreCard = await _context.ScoreCards.FindAsync(id);
            if (scoreCard == null)
            {
                return NotFound();
            }
            ViewData["PlayerId"] = new SelectList(_context.Players, "Id", "Id", scoreCard.PlayerId);
            return View(scoreCard);
        }

        // POST: ScoreCards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("First,Second,Third,Fourth,Fifth,Sixth,Seventh,Eighth,Ninth,Tenth,Eleventh,Twelwth,Thirteenth,Fourteenth,Fifteenth,Sixteenth,Seventeenth,Eithteenth,PlayerId,Id,Created")] ScoreCard scoreCard)
        {
            if (id != scoreCard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scoreCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScoreCardExists(scoreCard.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlayerId"] = new SelectList(_context.Players, "Id", "Id", scoreCard.PlayerId);
            return View(scoreCard);
        }

        [HttpPost("api/scorecards/update")]
        public async Task<IActionResult> UpdateScoreCardApi([FromBody] FullCardDto card)
        {

                    var scoreCard = await _repository.GetById(card.Id);

                    var player = await _playerRepository.GetById(card.PlayerId);

                    var scores = scoreCard.Scores.ToList();

                    var first = scores.Where(s => s.HoleNumber == 1).FirstOrDefault();
                    first.Gross = card.First;

                    var second = scores.Where(s => s.HoleNumber == 2).FirstOrDefault();
                    second.Gross = card.Second;

                    var third = scores.Where(s => s.HoleNumber == 3).FirstOrDefault();
                    third.Gross = card.Third;

                    var fourth = scores.Where(s => s.HoleNumber == 4).FirstOrDefault();
                    fourth.Gross = card.Fourth;

                    var fifth = scores.Where(s => s.HoleNumber == 5).FirstOrDefault();
                    fifth.Gross = card.Fifth;

                    var sixth = scores.Where(s => s.HoleNumber == 6).FirstOrDefault();
                    sixth.Gross = card.Sixth;

                    var seventh = scores.Where(s => s.HoleNumber == 7).FirstOrDefault();
                    seventh.Gross = card.Seventh;

                    var eighth = scores.Where(s => s.HoleNumber == 8).FirstOrDefault();
                    eighth.Gross = card.Eighth;

                    var ninth = scores.Where(s => s.HoleNumber == 9).FirstOrDefault();
                    ninth.Gross = card.Ninth;

                    var tenth = scores.Where(s => s.HoleNumber == 10).FirstOrDefault();
                    tenth.Gross = card.Tenth;

                    var eleventh = scores.Where(s => s.HoleNumber == 11).FirstOrDefault();
                    eleventh.Gross = card.Eleventh;

                    var twelfth = scores.Where(s => s.HoleNumber == 12).FirstOrDefault();
                    twelfth.Gross = card.Twelfth;

                    var thirteenth = scores.Where(s => s.HoleNumber == 13).FirstOrDefault();
                    thirteenth.Gross = card.Thirteenth;

                    var fourteenth = scores.Where(s => s.HoleNumber == 14).FirstOrDefault();
                    fourteenth.Gross = card.Fourteenth;

                    var fifteenth = scores.Where(s => s.HoleNumber == 15).FirstOrDefault();
                    fifteenth.Gross = card.Fifteenth;

                    var sixteenth = scores.Where(s => s.HoleNumber == 16).FirstOrDefault();
                    sixteenth.Gross = card.Sixteenth;

                    var seventeenth = scores.Where(s => s.HoleNumber == 17).FirstOrDefault();
                    seventeenth.Gross = card.Seventeenth;

                    var eighteenth = scores.Where(s => s.HoleNumber == 18).FirstOrDefault();
                    eighteenth.Gross = card.Eighteenth;




                    for (int i = 0; i < 18; i++)
                    {

                        var hole = scoreCard.Course.Holes.Where(h => h.Number == (i + 1)).FirstOrDefault();
                        var par = scoreCard.Course.Holes.Where(h => h.Number == (i + 1)).Select(h => h.Par).FirstOrDefault();

                        var score = scoreCard.Scores.Where(s => s.HoleNumber == (i + 1)).FirstOrDefault();

                        score.Nett = _scoreRepository.CalculateNettScore(score.Gross, hole, scoreCard.EventHandicap);
                        score.Points = _scoreRepository.CalculatePoints(score.Nett, hole.Par);
                        //var gross = scores[i];

                        //    scores[i].Nett = nett;
                        //    scores[i].Points = points;

                         _context.Score.Update(score);
                        

                    }


                if (!await _repository.SaveChanges())
                {
                    throw new Exception($"Failed to update Scorecard");
                }


            //var course = _context.Events
            //    .Where(e => e.Entries.Any(ev => ev.ScoreCard.Id == card.Id))
            //    .Select(e => e.Course).FirstOrDefault();

            var course = await _repository.GetCourseForScoreCard(card.Id);

            //var eventId = _context.Events.Where(e => e.Entries.Any(ev => ev.ScoreCard.Id == card.Id))
            //    .Select(e => e.Id).FirstOrDefault();

            var eventId = await _repository.GetEventIdForScoreCard(card.Id);



            var scoreCardToReturn = Mapper.Map<ScoreCardDto>(scoreCard);

            foreach (var score in scoreCardToReturn.Scores.OrderBy(h => h.HoleNumber))
            {
                var hole = course.Holes.Where(h => h.Number == score.HoleNumber).FirstOrDefault();
                score.Par = hole.Par;
                score.Index = hole.Index;
            }

            scoreCardToReturn.CourseName = course.Name;
            scoreCardToReturn.Course = Mapper.Map<CourseDto>(course);
            scoreCardToReturn.EventId = eventId;

            scoreCardToReturn.Scores.OrderBy(s => s.HoleNumber);

            var scoresToReturn = Mapper.Map<IEnumerable<ScoreDto>>(scoreCardToReturn.Scores).ToList();

            scoreCardToReturn.Scores = scoresToReturn;
            scoreCardToReturn.Scores = scoreCardToReturn.Scores.OrderBy(h => h.HoleNumber).ToList();

            return Ok(scoreCardToReturn);


            
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Players/{playerId}/Scorecards/{id}")]
        public async Task<IActionResult> UpdateCard(Guid id, Guid playerId, [Bind("First,Second,Third,Fourth,Fifth,Sixth,Seventh,Eighth,Ninth,Tenth,Eleventh,Twelwth,Thirteenth,Fourteenth,Fifteenth,Sixteenth,Seventeenth,Eithteenth,PlayerId,Id,Created")]
            PlayerCardDto card)
        {
            if (id != card.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var scoreCard = await _repository.GetById(id);

                    var player = await _playerRepository.GetById(playerId);

                    var scores = new List<int>();

                    scores.Add(card.First);
                    scores.Add(card.Second);
                    scores.Add(card.Third);
                    scores.Add(card.Fourth);
                    scores.Add(card.Fifth);
                    scores.Add(card.Sixth);
                    scores.Add(card.Seventh);
                    scores.Add(card.Eighth);
                    scores.Add(card.Ninth);
                    scores.Add(card.Tenth);
                    scores.Add(card.Eleventh);
                    scores.Add(card.Twelwth);
                    scores.Add(card.Thirteenth);
                    scores.Add(card.Fourteenth);
                    scores.Add(card.Fifteenth);
                    scores.Add(card.Sixteenth);
                    scores.Add(card.Seventeenth);
                    scores.Add(card.Eithteenth);

                    for (int i = 0; i < 18; i++)
                    {

                            var hole = scoreCard.Course.Holes.Where(h => h.Number == (i+1)).FirstOrDefault();
                            var par = scoreCard.Course.Holes.Where(h => h.Number == (i+1)).Select(h => h.Par).FirstOrDefault();
                            var nett = _scoreRepository.CalculateNettScore(scores[i], hole, scoreCard.EventHandicap);
                            var points = _scoreRepository.CalculatePoints(nett, hole.Par);
                            var score = scoreCard.Scores.Where(s => s.HoleNumber == (i+1)).FirstOrDefault();
                            var gross = scores[i];

                        if (score == null)
                        {

                            var scoreToAdd = new Score()
                                {
                                    Gross = gross,
                                    Nett = nett,
                                    Points = points,
                                    HoleNumber = hole.Number,
                                    Created = DateTimeOffset.Now
                                };

                                scoreCard.Scores.Add(scoreToAdd);
                        }
                        else
                        {
                            score.Gross = gross;
                            score.Nett = nett;
                            score.Points = points;
                            score.HoleNumber = hole.Number;

                            _context.Update(score);
                        }

                    }


                    //_context.Update(card);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScoreCardExists(card.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(card);
        }


        // GET: ScoreCards/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scoreCard = await _context.ScoreCards
                .Include(s => s.Player)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scoreCard == null)
            {
                return NotFound();
            }

            return View(scoreCard);
        }

        // POST: ScoreCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var scoreCard = await _context.ScoreCards.FindAsync(id);
            _context.ScoreCards.Remove(scoreCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScoreCardExists(Guid id)
        {
            return _context.ScoreCards.Any(e => e.Id == id);
        }
    }
}
