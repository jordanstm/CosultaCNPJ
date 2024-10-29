//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;
//using System.Net.Http;
//using HtmlAgilityPack;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

//namespace ConsultaCNPJ
//{
//    public class ConsultaSintegra
//    {
      
//        public static void PreparaPagina(string CNPJ)
//        {
           


//                IWebDriver driver = new ChromeDriver();

//                try
//                {
//                    driver.Navigate().GoToUrl("https://app.sefa.pa.gov.br/sintegra/");

//                    // Clica no checkbox "Não sou um robô"
//                    IWebElement checkbox = driver.FindElement(By.ClassName("g-recaptcha"));
//                    checkbox.Click();

//                    // Preenche o campo CNPJ
//                    IWebElement cnpjInput = driver.FindElement(By.Id("CNPJ"));
//                    cnpjInput.SendKeys(CNPJ); // Substitua pelo CNPJ desejado

//                    // Clica no botão "Consultar"
//                    IWebElement consultarButton = driver.FindElement(By.ClassName("button"));
//                    consultarButton.Click();
//                string html = driver.PageSource;
//                BuscaDados(html);
//                    // Agora você pode extrair os dados da página conforme necessário
//                    // ...

//                    // Feche o navegador
//                    driver.Quit();
//                }
//                catch (Exception ex)
//                {
//                    Console.WriteLine($"Erro: {ex.Message}");
//                }
//            }


//        public static  async void BuscaDados(string HTML)  //Alterar  o Tipo de dados 
//        {
//            var httpClient = new HttpClient();
//            var url = "https://app.sefa.pa.gov.br/sintegra/";

//            var response = await httpClient.GetAsync(url);
//            var html = await response.Content.ReadAsStringAsync();

//            var htmlDoc = new HtmlDocument();
//            htmlDoc.Load(HTML.Length>0? HTML:html);

//            // Use o HtmlAgilityPack para localizar os elementos relevantes
//            // Extraia os dados e preencha a classe Empresa
//            // ...

//            // Exemplo de uso:

//        }

//    }




//}
