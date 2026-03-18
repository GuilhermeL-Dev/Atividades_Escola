using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

Console.WriteLine("Iniciando o teste de Front-end...");

// 1. Configura o Driver (Abre o Chrome)
IWebDriver driver = new ChromeDriver();

try
{
    // 2. Navegação: Abre o Google
    driver.Navigate().GoToUrl("https://www.google.com");
    Console.WriteLine("Página aberta: " + driver.Title);

    // 3. Localização: Acha a barra de pesquisa pelo nome 'q'
    IWebElement campoBusca = driver.FindElement(By.Name("q"));

    // 4. Ação: Digita o texto e envia (Enter)
    campoBusca.SendKeys("Teste de Software com Selenium");
    campoBusca.Submit();

    // 5. Verificação
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("Busca realizada com sucesso!");
}
catch (Exception ex)
{
    Console.WriteLine("Ocorreu um erro: " + ex.Message);
}

