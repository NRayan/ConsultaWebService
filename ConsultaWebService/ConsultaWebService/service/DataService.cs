using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using ConsultaWebService.models;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsultaWebService.service
{
    public class DataService
    {
        HttpClient client = new HttpClient();
              
        public async Task<endereco> buscarendereco(string cep)
        {
            try
            {
                string url = "https://viacep.com.br/ws/"+cep+"/json/";
                var resposta = await client.GetStringAsync(url);
                var endr = JsonConvert.DeserializeObject<endereco>(resposta);
                return endr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
