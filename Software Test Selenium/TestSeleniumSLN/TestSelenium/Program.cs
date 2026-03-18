using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

// 1. Início do Programa
Console.WriteLine("Iniciando o teste de Front-end...");

// 2. Configura o Driver (Abre o Chrome)
IWebDriver driver = new ChromeDriver();

try
{
    // 3. Navegação: Vai para o site desejado
    driver.Navigate().GoToUrl("https://www.google.com");
    Console.WriteLine("Página aberta: " + driver.Title);

    // 4. Localização: Acha a barra de pesquisa pelo nome 'q'
    IWebElement campoBusca = driver.FindElement(By.Name("q"));

    // 5. Ação: Digita o texto e envia (Enter)
    campoBusca.SendKeys("Neymar");
    campoBusca.Submit();

    // 6. Verificação
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("Busca realizada com sucesso!");
}
catch (Exception ex)
{
    Console.WriteLine("Ocorreu um erro: " + ex.Message);
}

