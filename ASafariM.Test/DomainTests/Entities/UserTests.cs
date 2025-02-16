using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using ASafariM.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ASafariM.Test.DomainTests.Entities
{
    [TestClass]
    public class UserTests : TestBase
    {
        private User _user;

        [TestInitialize]
        public void Setup()
        {
            _user = new User();
        }
    }
}
