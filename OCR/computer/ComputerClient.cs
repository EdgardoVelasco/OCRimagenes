using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;

namespace OCR.computer
{
    class ComputerClient
    {
        private static readonly string APIKEY = "c335ea0982e543719821285136e137f4";
        private static readonly string ENDPOINT = "https://computerenvef.cognitiveservices.azure.com/";
        public static ComputerVisionClient Cliente { get; private set; }

        static ComputerClient() { InitComputer(); }

        private static void InitComputer() {
            var credenciales = new ApiKeyServiceClientCredentials(APIKEY);
            Cliente = new ComputerVisionClient(credenciales) { Endpoint=ENDPOINT};
        }

        
    }
}
