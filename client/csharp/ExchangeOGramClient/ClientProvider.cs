﻿using System;
using System.IO;
using System.Reflection;
using Grpc.Core;

namespace ExchangeOGram
{
    public class ClientProvider
    {
        const string CaPemResourceName = "ExchangeOGramClient.ca.pem";
        const string BackendHostEnvName = "EXCHANGEOGRAM_BACKEND_HOST";
        const int BackendPort = 8433;

        Channel channel;
        WallService.WallServiceClient wallClient;
        MediaService.MediaServiceClient mediaClient;

        public ClientProvider()
        {
            this.channel = new Channel(GetBackendHost(), BackendPort, GetSslCredentials());
            this.wallClient = new WallService.WallServiceClient(channel);
            this.mediaClient = new MediaService.MediaServiceClient(channel);
        }

        public WallService.WallServiceClient WallClient
        {
            get => wallClient;
        }

        public MediaService.MediaServiceClient MediaClient {
            get => mediaClient;
        }

        private SslCredentials GetSslCredentials()
        {
            // read the certificate authority from an embedded resource
            var stream = typeof(ClientProvider).GetTypeInfo().Assembly.GetManifestResourceStream(CaPemResourceName);
            using (var streamReader = new StreamReader(stream))
            {
                return new SslCredentials(streamReader.ReadToEnd());
            }
        }

        private string GetBackendHost()
        {
           var backendHost = Environment.GetEnvironmentVariable(BackendHostEnvName);
           if (!string.IsNullOrEmpty(backendHost))
           {
               return backendHost;
           }
           return "localhost";
        }
    }
}
