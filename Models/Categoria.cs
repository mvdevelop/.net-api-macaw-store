
// Models/Categoria.cs
namespace EstoqueAPI.Models
{
    public static class Categorias
    {
        public const string Geladeira = "Geladeira";
        public const string Fogao = "Fogão";
        public const string Microondas = "Microondas";
        public const string Televisao = "Televisão";
        public const string Smartphone = "Smartphone";
        public const string Notebook = "Notebook";
        public const string Tablet = "Tablet";
        public const string Audio = "Áudio";
        public const string Video = "Vídeo";
        
        public static List<string> ListarCategorias()
        {
            return new List<string>
            {
                Geladeira, Fogao, Microondas, Televisao,
                Smartphone, Notebook, Tablet, Audio, Video
            };
        }
    }
}
