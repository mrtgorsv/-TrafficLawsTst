using System.IO;
using System.Linq;
using System.Reflection;

namespace TrafficLawsTest.DataSource.Utils
{
    /// <summary>
    /// Класс для работы с изображениями приложения
    /// </summary>
    public static class ImageLoader
    {
        public static byte[] FromAssembly(string name)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = assembly.GetManifestResourceNames()
                .Single(str => str.Contains(name));

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null) return null;
                byte[] ba = new byte[stream.Length];
                stream.Read(ba, 0, ba.Length);
                return ba;
            }
        }
    }
}
