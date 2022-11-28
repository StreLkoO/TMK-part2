using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TMK_plus_plus.Interfaces;

namespace TMK_plus_plus.Classes
{
    internal class PipeXmlReader : IPipeRepo
    {
        private readonly string path;
        private List<Pipe> pipes;

        public PipeXmlReader(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException(nameof(path));

            this.path = path;
            pipes = new List<Pipe>();
        }

        private void WriteFile()
        {
            var serializer = new XmlSerializer(typeof(List<Pipe>));

            using (var writer = new StreamWriter(path, false))
            {
                serializer.Serialize(writer, pipes);
            }
        }

        private void ReadFile()
        {
            var contents = String.Empty;

            if (File.Exists(path))
            {
                contents = File.ReadAllText(path);
            }

            if (String.IsNullOrEmpty(contents))
            {
                return;
            }

            var serializer = new XmlSerializer(typeof(List<Pipe>));
            using (var reader = new StringReader(contents))
            {
                var records = (List<Pipe>)serializer.Deserialize(reader)!;

                pipes.Clear();
                pipes.AddRange(records);
            }
        }
        public async Task<bool> AddPipe(Pipe pipe)
        {
            if (pipe == null)
                throw new ArgumentNullException(nameof(pipe));
            if (pipe.Number != 0)
                throw new ArgumentException(nameof(pipe));

            if (pipes.Count == 0)
            {
                pipe.Number = 1;
            }
            else
            {
                pipe.Number = pipes.Max(p => p.Number) + 1;
            }

            pipes.Add(pipe);

            try
            {
                await Task.Run(() => WriteFile());
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка {ex.Message} записи файла {path}");
                return false;
            }

            return true;
        }

        public async Task<bool> DeletePipe(Pipe pipe)
        {
            if (pipe == null)
                throw new ArgumentNullException(nameof(pipe));
            Pipe? searchPipe = pipes.Find(p => p.Number == pipe.Number);
            if (searchPipe == null)
                throw new ArgumentException(nameof(pipe));
            pipes.Remove(searchPipe);
            try
            {
                await Task.Run(() => WriteFile());
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка {ex.Message} записи файла {path}");
                return false;
            }
            return true;
        }

        public async Task<List<Pipe>> GetPipes()
        {
            try
            {
                await Task.Run(() => ReadFile());
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка {ex.Message} чтения файла {path}");
            }

            return pipes;
        }

        public async Task<bool> UpdatePipe(Pipe pipe)
        {
            if (pipe == null)
                throw new ArgumentNullException(nameof(pipe));
            Pipe? searchPipe = pipes.Find(p => p.Number == pipe.Number);
            if (searchPipe == null)
                throw new ArgumentException(nameof(pipe));
            int num = pipes.IndexOf(searchPipe);
            pipes[num] = pipe;
            try
            {
                await Task.Run(() => WriteFile());
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка {ex.Message} записи файла {path}");
                return false;
            }
            return true;
        }
    }
}
