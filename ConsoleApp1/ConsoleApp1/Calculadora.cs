namespace ConsoleApp1
{
    public class Calculadora
    {
        private List<string>? listaHistorico;
        private DateTime data;

        public Calculadora(DateTime data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int somar(int val1, int val2)
        {
            var resultado = val1 + val2;

            listaHistorico?.Add($"Resultado: {resultado}, Data: {data}");

            return resultado;
        }
        public int subtrair(int val1, int val2)
        {
            var resultado = val1 - val2;

            listaHistorico?.Add($"Resultado: {resultado}, Data: {data}");

            return resultado;
        }
        public int dividir(int val1, int val2)
        {
            var resultado = val1 / val2;

            listaHistorico?.Add($"Resultado: {resultado}, Data: {data}");

            return resultado;
        }       
        public int multiplicar(int val1, int val2)
        {
            var resultado = val1 * val2;

            listaHistorico?.Add($"Resultado: {resultado}, Data: {data}");

            return resultado;
        }
        public List<string> historico()
        {
            if(listaHistorico == null)
                return new List<string>();

            return listaHistorico.TakeLast(3).ToList();            
        }
    }
}
