using System;
using System.Collections.Generic;
using ASafariM.Application.DTOs;
using ASafariM.Application.Mappings;
using ASafariM.Domain.Entities;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASafariM.Test.ApplicationTests.Mappings
{
    [TestClass]
    public class UserMappingProfileTests : TestBase
    {
        private IMapper _mapper;

        [TestInitialize]
        public override void Setup()
        {
            base.Setup();
            var config = new MapperConfiguration(cfg => cfg.AddProfile<UserMappingProfile>());
            _mapper = config.CreateMapper();
        }


    }
}
