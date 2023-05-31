try
{
    /*
    Console.WriteLine("ConsultarV1:");
    var resultado = await ViaCepConsumidor.ConsultarV1("01001000");
    Console.WriteLine(resultado.IsSuccessStatusCode);
    Console.WriteLine(resultado.StatusCode);
    var dados = await resultado.Content.ReadAsStringAsync();
    Console.WriteLine(dados);
    */
    /*
    Console.WriteLine("ConsultarV2:");
    var resultado = await ViaCepConsumidor.ConsultarV2("0100100");
    Console.WriteLine(resultado);
    */
    Console.WriteLine("ConsultarV3:");
    var resultado = await ViaCepConsumidor.ConsultarV3("01001000");
    if (resultado != null)
    {
        Console.WriteLine(resultado.Cep);
        Console.WriteLine(resultado.Uf);
    }
}
catch(Exception e)
{
    Console.WriteLine("Falha:");
    Console.WriteLine(e.Message);
}