using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebApi.Models.Repository;

namespace CoreWebApi.Models.DataManager
{
    public class EvaluationManager : IDataRepository<Evaluation>
    {
        readonly MoodFullContext _moodfullContext;

        public EvaluationManager(MoodFullContext context)
        {
            _moodfullContext = context;
        }

        public IEnumerable<Evaluation> GetAll()
        {
            return _moodfullContext.Evaluations.ToList();
        }

        public Evaluation Get(long id)
        {
            return _moodfullContext.Evaluations
                  .FirstOrDefault(e => e.EvaluationId == id);
        }

        public void Add(Evaluation entity)
        {
            _moodfullContext.Evaluations.Add(entity);
            _moodfullContext.SaveChanges();
        }

        public void Update(Evaluation evaluation, Evaluation entity)
        {
            evaluation.MoodRating = entity.MoodRating;
            evaluation.Price = entity.Price;
            evaluation.Experience = entity.Experience;

            _moodfullContext.SaveChanges();
        }

        public void Delete(Evaluation evaluation)
        {
            _moodfullContext.Evaluations.Remove(evaluation);
            _moodfullContext.SaveChanges();
        }
    }
}
