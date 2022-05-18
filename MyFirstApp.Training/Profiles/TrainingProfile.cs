using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EO = MyFirstApp.Training.Entities;
using BO = MyFirstApp.Training.BusinessObject;
namespace MyFirstApp.Training.Profiles
{
    public class TrainingProfile: Profile
    {
        public TrainingProfile()
        {
            CreateMap<EO.Course, BO.Course>().ReverseMap();
        }
    }
}
