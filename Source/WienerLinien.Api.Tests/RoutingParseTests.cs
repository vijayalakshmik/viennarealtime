﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WienerLinien.Api.Routing;
using WienerLinien.Api.Routing.Messages;

namespace WienerLinien.Api.Tests
{
    [TestFixture]
    public class RoutingParseTests
    {
        [Test]
        [Ignore]
        public void BuggyXmlRoutingParseTest()
        {
            //var schnittstelle = new RoutingSchnittstelle();
            //bool ok = schnittstelle.ParseRoutingRequestResponse(ResponseFiles.Load(ResponseFiles.RoutingFahrtoptionen8));

            var ok = MessageSerializationHelper.DeserializeFromString<WienerLinien.Api.Routing.Messages2.itdRequestType>(ResponseFiles.Load(ResponseFiles.RoutingFahrtoptionen8));
            // HResult=-2146233079
            // Message=Unable to generate a temporary class (result=1).

            Assert.That(ok, Is.EqualTo(true));
        }

        [Test]
        public void SimpleRoutingParseTest()
        {
            var schnittstelle = new RoutingSchnittstelle();
            var result = schnittstelle.ParseRoutingRequestResponse(ResponseFiles.LoadJson(ResponseFiles.RoutingFahrtoptionen8Json));

            Assert.That(result.Succeeded, Is.EqualTo(true));
        }

        [Test]
        public void SalztorbrueckeWestbahnhofTest()
        {
            var schnittstelle = new RoutingSchnittstelle();
            var result = schnittstelle.ParseRoutingRequestResponse(ResponseFiles.LoadJson(ResponseFiles.RoutingSalztorbrueckeWestbahnhofJson));

            Assert.That(result.Succeeded, Is.EqualTo(true));
            Assert.That(result.Trips.Count, Is.EqualTo(4));
        }
    }
}
