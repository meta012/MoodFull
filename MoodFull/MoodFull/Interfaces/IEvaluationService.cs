using MoodFull.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MoodFull.Interfaces
{
    interface IEvaluationService
    {
        //Gauna ivertinimu sarasa
        Task<List<Evaluation>> GetEvaluationsAsync();

        //Gauna konkretu ivertinima pagal jo ID
        Task<Evaluation> GetEvaluationAsync(long id);

        //Insertina nauja evaltion
        Task PostEvaluationAsync(Evaluation evaluation);

        //Atnaujina esama Evaluation
        Task PutEvaluationAsync(long id, Evaluation evaluation);

        //Istrina esama Evaluation
        Task DeleteEvaluationAsync(long id);
    }
}
