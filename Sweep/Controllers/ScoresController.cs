using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GolfSweep.Data;
using GolfSweep.Dtos;
using GolfSweep.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GolfSweep.Controllers
{
    public class ScoresController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IScoreRepository _repository;
        private readonly IRepository<Course> _courseRepository;
        private readonly IRepository<Player> _playerRepository;
        private readonly IRepository<ScoreCard> _cardRepository;

        public ScoresController(ApplicationDbContext context,
            IScoreRepository repository,
            IRepository<Course> courseRepository,
            IRepository<Player> playerRepository,
            IRepository<ScoreCard> cardRepository)
        {
            _context = context;
            _repository = repository;
            _courseRepository = courseRepository;
            _playerRepository = playerRepository;
            _cardRepository = cardRepository;
        }

        [HttpPost("api/scores/createCard")]
        public async Task<IActionResult> CreateScoreCard([FromBody] CreateScoresDto dto)
        {
            var scoreCard = await _cardRepository.GetById(dto.Id);
            var course = await _courseRepository.GetById(dto.CourseId);


            var scores = new List<Score>();

            foreach (var hole in scoreCard.Course.Holes.OrderBy(h => h.Number).ToList())
            {
                var score = new Score()
                {
                    Id = Guid.NewGuid(),
                    Gross = 0,
                    Nett = 0,
                    Points = 0,
                    HoleNumber = hole.Number
                };

                scores.Add(score);
                //entry.ScoreCard.Scores.Add(score);
            }

            scoreCard.Scores = scores;

            if (! await _repository.SaveChanges())
            {
                throw new Exception($"Failed to create scores for scoreCardId: {scoreCard.Id}");
            }

            var scoresToReturn = Mapper.Map<IEnumerable<ScoreDto>>(scoreCard.Scores);

            return Ok(scoresToReturn.OrderBy(s => s.HoleNumber));
        }

        [HttpPost("api/scores")]
        public async Task<IActionResult> UpdateScore([FromBody] ScoreDto dto)
        {
            var course = await _courseRepository.GetById(dto.CourseId);
            var player = await _playerRepository.GetById(dto.PlayerId);
            var card = await _cardRepository.GetById(dto.CardId);

            var scoreToUpdate = await _repository.GetById(dto.Id);

            var hole = course.Holes.Where(h => h.Number == dto.HoleNumber).FirstOrDefault();
            var par = course.Holes.Where(h => h.Number == dto.HoleNumber).Select(h => h.Par).FirstOrDefault();
            var nett = _repository.CalculateNettScore(dto.Gross, hole, card.EventHandicap);
            var points = _repository.CalculatePoints(nett, hole.Par);

            dto.Nett = nett;
            dto.Points = points;
            dto.Course = Mapper.Map<CourseDto>(course);


            if (scoreToUpdate != null)
            {

                Mapper.Map(dto, scoreToUpdate);

                _context.Score.Update(scoreToUpdate);


            }
            else
            {
                scoreToUpdate = new Score()
                {
                    Gross = dto.Gross,
                    Nett = nett,
                    Points = points,
                    HoleNumber = hole.Number,
                    Created = DateTimeOffset.Now

                };

                var cardToUpdate = await _cardRepository.GetById(dto.CardId);

                cardToUpdate.Scores.Add(scoreToUpdate);


            }

            if (!await _repository.SaveChanges())
            {
                throw new Exception($"Unable to update Score Id: {dto.Id}");
            }

            var scoreToReturn = Mapper.Map<ScoreDto>(scoreToUpdate);

            return Ok(scoreToReturn);



        }


    }
}