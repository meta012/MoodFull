using MoodFull.RestClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MoodFull.Models;
using MoodFull.Interfaces;

namespace MoodFull.Services
{
    public class EvaluationService: IEvaluationService
    {
        private const string evaluationUrl = "Evaluations";
        //Gauna evaluationus
        public async Task<List<Evaluation>> GetEvaluationsAsync()
        {
            RestClient<Evaluation> restClient = new RestClient<Evaluation>();
            var evaluationsList = await restClient.GetAsync(evaluationUrl);
            return evaluationsList;
        }

        //Gauna viena evaluationa pagal id
        public async Task<Evaluation> GetEvaluationAsync(long id)
        {
            RestClient<Evaluation> restClient = new RestClient<Evaluation>();
            var evaluation = await restClient.GetAsync(id, evaluationUrl);
            return evaluation;
        }

        //Insertina nauja evaluationa
        public async Task PostEvaluationAsync(Evaluation evaluation)
        {
            RestClient<Evaluation> restClient = new RestClient<Evaluation>();
            var isSuccess = await restClient.PostAsync(evaluation, evaluationUrl);
        }

        //Upadtina esama evaluationa. 
        public async Task PutEvaluationAsync(long id, Evaluation evaluation)
        {
            RestClient<Evaluation> restClient = new RestClient<Evaluation>();
            var isSuccess = await restClient.PutAsync(id, evaluation, evaluationUrl);
        }
        public async Task DeleteEvaluationAsync(long id)
        {
            RestClient<Evaluation> restClient = new RestClient<Evaluation>();
            var isSuccess = await restClient.DeleteAsync(id, evaluationUrl);
        }
    }
}