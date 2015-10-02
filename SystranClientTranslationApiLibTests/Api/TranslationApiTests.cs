using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Systran.TranslationClientLib.Client;
using Systran.TranslationClientLib.Api;
using Systran.TranslationClientLib.Model;
using System.IO;

namespace Systran.Tests
{
    [TestClass()]
    public class TranslationApiTests
    {
        private static ApiClient client;
        private static TranslationApi translationApi;


        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            client = new ApiClient("https://platform.systran.net:8904");
            Configuration.apiClient = client;
            Dictionary<String, String> keys = new Dictionary<String, String>();
            string key;
            using (StreamReader streamReader = new StreamReader("../../apiKey.txt", Encoding.UTF8))
            {
                key = streamReader.ReadToEnd();
            }
            keys.Add("key", key); Configuration.apiKey = keys; Configuration.apiKey = keys;
            Configuration.apiKey = keys;
            translationApi = new TranslationApi(Configuration.apiClient);
        }


        [TestMethod()]
        public void GetBasePathTest()
        {
            Assert.IsInstanceOfType(translationApi.apiClient.basePath, typeof(string));
        }

        [TestMethod()]
        public void TranslationBatchCancelGetTest()
        {
            BatchCreate batchCreate = new BatchCreate();
            batchCreate = translationApi.TranslationBatchCreateGet(null);
            BatchCancel batchCancel = new BatchCancel();
            batchCancel = translationApi.TranslationBatchCancelGet(batchCreate.BatchId, null);
            Assert.IsNotNull(batchCancel.Status);
        }

        [TestMethod()]
        public void TranslationBatchCancelGetAsyncTest()
        {
            BatchCreate batchCreate = new BatchCreate();
            batchCreate = translationApi.TranslationBatchCreateGet(null);
            BatchCancel batchCancel = new BatchCancel();
            Task.Run(async () =>
            {
                batchCancel = await translationApi.TranslationBatchCancelGetAsync(batchCreate.BatchId, null);
            }).Wait();
            Assert.IsNotNull(batchCancel.Status);
        }

        [TestMethod()]
        public void TranslationBatchCloseGetTest()
        {
            BatchCreate batchCreate = new BatchCreate();
            batchCreate = translationApi.TranslationBatchCreateGet(null);
            BatchClose batchClose = new BatchClose();
            batchClose = translationApi.TranslationBatchCloseGet(batchCreate.BatchId, null);
            Assert.IsNotNull(batchClose.Status);
        }

        [TestMethod()]
        public void TranslationBatchCloseGetAsyncTest()
        {
            BatchCreate batchCreate = new BatchCreate();
            batchCreate = translationApi.TranslationBatchCreateGet(null);
            BatchClose batchClose = new BatchClose();
            Task.Run(async () =>
            {
                batchClose = await translationApi.TranslationBatchCloseGetAsync(batchCreate.BatchId, null);
            }).Wait();
            Assert.IsNotNull(batchClose.Status);
        }

        [TestMethod()]
        public void TranslationBatchCreateGetTest()
        {
            BatchCreate batchCreate = new BatchCreate();
            batchCreate = translationApi.TranslationBatchCreateGet(null);
            Assert.IsNotNull(batchCreate.BatchId);
        }

        [TestMethod()]
        public void TranslationBatchCreateGetAsyncTest()
        {
            BatchCreate batchCreate = new BatchCreate();
            Task.Run(async () =>
            {
                batchCreate = await translationApi.TranslationBatchCreateGetAsync(null);
            }).Wait();
            Assert.IsNotNull(batchCreate.BatchId);
        }

        [TestMethod()]
        public void TranslationBatchStatusGetTest()
        {
            BatchCreate batchCreate = new BatchCreate();
            batchCreate = translationApi.TranslationBatchCreateGet(null); BatchStatus batchStatus = new BatchStatus();
            batchStatus = translationApi.TranslationBatchStatusGet(batchCreate.BatchId, null);
            Assert.IsNotNull(batchStatus.Requests);
        }

        [TestMethod()]
        public void TranslationBatchStatusGetAsyncTest()
        {
            BatchCreate batchCreate = new BatchCreate();
            batchCreate = translationApi.TranslationBatchCreateGet(null); BatchStatus batchStatus = new BatchStatus();
            Task.Run(async () =>
            {
                batchStatus = await translationApi.TranslationBatchStatusGetAsync(batchCreate.BatchId, null);
            }).Wait();
            Assert.IsNotNull(batchStatus.Requests);
        }

        [TestMethod()]
        public void TranslationProfileGetTest()
        {
            ProfilesResponse profileResponse = new ProfilesResponse();
            profileResponse = translationApi.TranslationProfileGet("en", "fr", null, null);
            Assert.IsNotNull(profileResponse.Profiles);
        }

        [TestMethod()]
        public void TranslationProfileGetAsyncTest()
        {
            ProfilesResponse profileResponse = new ProfilesResponse();
            Task.Run(async () =>
            {
                profileResponse = await translationApi.TranslationProfileGetAsync("en", "fr", null, null);
            }).Wait();
            Assert.IsNotNull(profileResponse.Profiles);
        }

        [TestMethod()]
        public void TranslationSupportedLanguagesGetTest()
        {
            SupportedLanguageResponse supportedLanguageResponse = new SupportedLanguageResponse();
            supportedLanguageResponse = translationApi.TranslationSupportedLanguagesGet(null, null, null);
            Assert.IsNotNull(supportedLanguageResponse.LanguagePairs);
        }

        [TestMethod()]
        public void TranslationSupportedLanguagesGetAsyncTest()
        {
            SupportedLanguageResponse supportedLanguageResponse = new SupportedLanguageResponse();
            Task.Run(async () =>
            {
                supportedLanguageResponse = await translationApi.TranslationSupportedLanguagesGetAsync(null, null, null);
            }).Wait();
            Assert.IsNotNull(supportedLanguageResponse.LanguagePairs);
        }

        [TestMethod()]
        public void TranslationTranslateGetTest()
        {
            TranslationResponse response = new TranslationResponse();
            List<string> sample = new List<string>();
            sample.Add("this is a test");
            response = translationApi.TranslationTranslateGet(sample, "en", "fr", null, null, true, false, null, null, false, null, null, false, null, null);
            Assert.IsNotNull(response.Outputs);
        }

        [TestMethod()]
        public void TranslationTranslateGetAsyncTest()
        {
            TranslationResponse response = new TranslationResponse();
            List<string> sample = new List<string>();
            sample.Add("this is a test");
            Task.Run(async () =>
            {
                response = await translationApi.TranslationTranslateGetAsync(sample, "en", "fr", null, null, true, false, null, null, false, null, null, false, null, null);
            }).Wait();
     
            Assert.IsNotNull(response.Outputs[0]);
       }

        [TestMethod()]
        public void TranslationTranslateCancelGetTest()
        {
            TranslationFileResponse fileResponse = new TranslationFileResponse();
            fileResponse = translationApi.TranslationTranslateFileGet("../../test.txt", "en", "fr", null, null, false, false, null, null, null, null, true, null, null);

            TranslationCancel translationCancel = new TranslationCancel();
            translationCancel = translationApi.TranslationTranslateCancelGet(fileResponse.RequestId, null);
            Assert.IsNotNull(translationCancel.ToString());
        }

        [TestMethod()]
        public void TranslationTranslateFileGetTest()
        {
            TranslationFileResponse fileResponse = new TranslationFileResponse();
            fileResponse = translationApi.TranslationTranslateFileGet("../../test.txt", "en", "fr", null, null, false, false, null, null, null, null, false, null, null);
            Assert.IsNotNull(fileResponse);
        }

        [TestMethod()]
        public void TranslationTranslateFileGetAsyncTest()
        {
            TranslationFileResponse fileResponse = new TranslationFileResponse();
            Task.Run(async () =>
            {
                fileResponse = await translationApi.TranslationTranslateFileGetAsync("../../test.txt", "en", "fr", null, null, true, false, null, null, null, null, false, null, null);
            }).Wait();
            Assert.IsNotNull(fileResponse);
        }

        [TestMethod()]
        public void TranslationTranslateResultGetTest()
        {
            TranslationFileResponse fileResponse = new TranslationFileResponse();
            fileResponse = translationApi.TranslationTranslateFileGet("../../test.txt", "en", "fr", null, null, false, false, null, null, null, null, true, null, null);

            String translationResponse = null;
            translationResponse = translationApi.TranslationTranslateResultGet(fileResponse.RequestId, null);
            Assert.IsNotNull(translationResponse);
        }

        [TestMethod()]
        public void TranslationTranslateResultGetAsyncTest()
        {
            TranslationFileResponse fileResponse = new TranslationFileResponse();
            fileResponse = translationApi.TranslationTranslateFileGet("../../test.txt", "en", "fr", null, null, false, false, null, null, null, null, true, null, null);


            String translationResponse = null ;
            Task.Run(async () =>
            {
                translationResponse = await translationApi.TranslationTranslateResultGetAsync(fileResponse.RequestId, null);
            }).Wait();
            Assert.IsNotNull(translationResponse);
        }

        [TestMethod()]
        public void TranslationTranslateStatusGetTest()
        {
            TranslationFileResponse fileResponse = new TranslationFileResponse();
            fileResponse = translationApi.TranslationTranslateFileGet("../../test.txt", "en", "fr", null, null, false, false, null, null, null, null, true, null, null);

            TranslationStatus translationStatus = new TranslationStatus();
            translationStatus = translationApi.TranslationTranslateStatusGet(fileResponse.RequestId, null);
            Assert.IsNotNull(translationStatus.Status);
        }

    }
}