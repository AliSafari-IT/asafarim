using System;
using ASafariM.Application.DTOs;
using ASafariM.Application.Mappings;
using ASafariM.Domain.Entities;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASafariM.Test.ApplicationTests.Mappings
{
    [TestClass]
    public class AutoMapperProfileTests : TestBase
    {
        private IMapper _mapper;

        [TestInitialize]
        public override void Setup()
        {
            base.Setup();
            var config = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
            _mapper = config.CreateMapper();
        }


    }
}
