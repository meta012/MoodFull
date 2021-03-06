﻿using MoodFull.Models;
using MoodFull.Services;
using MoodFull.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodFull.ViewModels
{
    public class TopUserViewModel : BaseViewModel
    {
        private List<Evaluation> _evaluationList = new List<Evaluation>();
        private User _selectedUser = new User();
        private long _topUserId;
        private int _topUserIdCount;
        private IUserService userService = ServiceFactory.GetUserService();
        private IEvaluationService evaluationService = ServiceFactory.GetEvaluationService();

        public List<Evaluation> EvaluationsList
        {
            get { return _evaluationList; }
            set
            {
                _evaluationList = value;
                OnPropertyChanged();
            }
        }
        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                OnPropertyChanged();
            }
        }
        public int TopUserIdCount
        {
            get { return _topUserIdCount; }
            set
            {
                _topUserIdCount = value;
                OnPropertyChanged();
            }
        }
        private void GetMaxUserIDCount()
        {
            var query = EvaluationsList.GroupBy(x => x.UserId)
                .Select(group => new { UserId = group.Key, Count = group.Count() })
                .OrderByDescending(x => x.Count);

            var item = query.First();

            _topUserId = item.UserId;
            _topUserIdCount = item.Count;
        }
        private async Task GetUser()
        {
            SelectedUser = await userService.GetUserAsync(_topUserId);
        }
        public TopUserViewModel ()
        {
            EvaluationsList = Task.Run(async () => await evaluationService.GetEvaluationsAsync()).Result;
            GetMaxUserIDCount();
            GetUser();

        }
    }
}
