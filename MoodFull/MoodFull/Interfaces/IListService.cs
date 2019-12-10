using MoodFull.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoodFull.Interfaces
{
    interface IListService
    {
        //Sumergina kelis listus. Reikia Evaluations skaciavimui
        List<MergedObject> SetMergedList(List<MergedObject> mergedList);

        //Nustato kiekvieno vartotojo Ivertinimus
        List<MergedObject> SetUsersEvaluations(List<MergedObject> mergedList);

        //Nustato kiekvieno restoranu vertinimo vidurkius
        List<MergedObject> SetRestaurantsAverageEvaluations(List<MergedObject> mergedList);

    }
}
