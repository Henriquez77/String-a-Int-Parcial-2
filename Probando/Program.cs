int dato = 16;
String dato2 = "25g";
try
{
    int resultado = dato + Convert.ToInt32(dato2);
}
catch (FormatException ex)
{
    Console.WriteLine($"Lo sentimos no se pudo realizar la operación solicitada porque: {ex.Message}");
}






