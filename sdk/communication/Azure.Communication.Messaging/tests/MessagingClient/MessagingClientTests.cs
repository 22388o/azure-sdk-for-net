// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Azure.Communication.Messaging
{
    public class MessagingClientTests
    {
        [Test]
        public async Task SendMessageShouldSucceed()
        {
            //arrange
            var uri = "endpoint=https://acsxxplatdemo.int.communication.azure.net/;accesskey=7zIRqTFXRyeBzypL08hu1tJh/QTLNvLChrodkr7FeqyhIfPHx21EPU7Z6BcGbMcNH2xvpcFhM4pi1r8UXgJMgA==";
            var messagingClient = new MessagingClient(uri);
            //MessageTemplate template = new MessageTemplate("appiontment_reminder", "en_ca", new List<string> { "friday", "10am" });
            var options = new SendMessageOptions("d8fbaac7-c949-4bf1-8ba9-29b467d97547", "+1(604)360-9258", "hiiiiii");
            SendMessageResponse response = await messagingClient.SendMessageAsync(options);
            var id = response.Result[0].Id;
            var status = response.Result[0].Status;
        }
    }
}
