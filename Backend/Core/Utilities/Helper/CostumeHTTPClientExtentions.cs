//using Core.Utilities.Exceptions;
//using System.Net;
//using System.Text;
//using System.Text.Json;

//namespace CoreMVC.Extentions
//{
//    public static class CostumeHTTPClientExtentions
//    {
//        public static async Task<(HttpResponseMessage, MVCDataResult<T>)> CostumeGetAsync<T>(this HttpClient httpClient, string Url, IToastNotification toastMessage)
//        {
//            var Response  = await httpClient.GetAsync(Url);
//            if (Response.IsSuccessStatusCode) /// İşlem başarı ile gerçekleştiyse bu operasyonlar gerçekleşecek
//            {
//                var json = await Response.Content.ReadAsStringAsync();
//                var ResponseData = JsonSerializer.Deserialize<MVCDataResult<T>>(json, new JsonSerializerOptions
//                {
//                    PropertyNameCaseInsensitive = true
//                });

//                if (!string.IsNullOrEmpty(Response.RequestMessage.ToString())) 
//                    toastMessage.AddSuccessToastMessage(Response.RequestMessage.ToString());

//                return (Response, ResponseData);

//            }
//            if (Response.StatusCode == HttpStatusCode.Unauthorized)
//            {
//                toastMessage.AddErrorToastMessage("Oturum süreniz doldu. Lütfen tekrar giriş yapınız. ");
//                throw new SessionExpiredException();

//            }
//            if (Response.StatusCode == HttpStatusCode.BadRequest)
//            {
//                return (Response, default(MVCDataResult<T>));
//            }

//            return (Response, default(MVCDataResult<T>));
//        }
   

//        public static async Task<(HttpResponseMessage, MVCDataResult<T>)> CostumePostAsync<T>(this HttpClient httpClient, string Url,string PostedData , IToastNotification toastMessage, Controller controller)
//        {

//            var jsonContent = new StringContent(PostedData, Encoding.UTF8, "application/json");

//            var Response = await httpClient.PostAsync(Url, jsonContent);

//            var json = await Response.Content.ReadAsStringAsync();

//            var ResponseData = JsonSerializer.Deserialize<MVCDataResult<T>>(json, new JsonSerializerOptions
//            {
//                PropertyNameCaseInsensitive = true
//            });


//            if (Response.IsSuccessStatusCode) /// İşlem başarı ile gerçekleştiyse bu operasyonlar gerçekleşecek
//            {
//                if (!string.IsNullOrEmpty(Response.RequestMessage.ToString()))

//                return (Response, (ResponseData));

//            }
//            if (Response.StatusCode == HttpStatusCode.Unauthorized)
//            {
//                throw new SessionExpiredException();

//            }
//            if (Response.StatusCode == HttpStatusCode.BadRequest)
//            {
//                if (ResponseData.ValidationErrors  != null)
//                {
//                    foreach (var item in ResponseData.ValidationErrors)
//                    {
//                        controller.ModelState.AddModelError(item.PropertyName, item.ErrorDescription);
//                    }

//                    toastMessage.AddErrorToastMessage(ResponseData.Messages);
//                }
//                return (Response, default(MVCDataResult<T>));

//            }
//            if (Response.StatusCode == HttpStatusCode.NotFound)
//            {
//                if (ResponseData.ValidationErrors != null)
//                {
//                    foreach (var item in ResponseData.ValidationErrors)
//                    {
//                        controller.ModelState.AddModelError(item.PropertyName, item.ErrorDescription);
//                    }

//                }
//                toastMessage.AddErrorToastMessage(ResponseData.Messages);


//                return (Response, default(MVCDataResult<T>));
//            }

//            return (Response, default(MVCDataResult<T>));
//        }


//    }
//}
