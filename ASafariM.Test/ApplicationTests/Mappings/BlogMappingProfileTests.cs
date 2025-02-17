using System;
using ASafariM.Application.CommandModels;
using ASafariM.Application.DTOs;
using ASafariM.Application.Mappings;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Enums;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASafariM.Test.ApplicationTests.Mappings
{
    [TestClass]
    public class BlogMappingProfileTests : TestBase
    {
        private IMapper _mapper;

        [TestInitialize]
        public override void Setup()
        {
            base.Setup();
            var config = new MapperConfiguration(cfg => cfg.AddProfile<BlogMappingProfile>());
            _mapper = config.CreateMapper();
        }

    }
}
