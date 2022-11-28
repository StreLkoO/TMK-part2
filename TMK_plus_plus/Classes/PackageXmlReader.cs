using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TMK_plus_plus.Interfaces;

namespace TMK_plus_plus.Classes
{
    public class PackageXmlReader : IPackageRepo
    {
        private readonly string path;
        private List<PipePackage> packages;

        public PackageXmlReader(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException(nameof(path));

            this.path = path;
            packages = new List<PipePackage>();
        }

        private void WriteFile()
        {
            var serializer = new XmlSerializer(typeof(List<PipePackage>));

            using (var writer = new StreamWriter(path, false))
            {
                serializer.Serialize(writer, packages);
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

            var serializer = new XmlSerializer(typeof(List<PipePackage>));
            using (var reader = new StringReader(contents))
            {
                var records = (List<PipePackage>)serializer.Deserialize(reader)!;

                packages.Clear();
                packages.AddRange(records);
            }
        }

        public async Task<bool> AddPackage(PipePackage package)
        {
            if (package == null)
                throw new ArgumentNullException(nameof(package));
            if (package.Number != 0)
                throw new ArgumentException(nameof(package));

            if (packages.Count == 0)
            {
                package.Number = 1;
            }
            else
            {
                package.Number = packages.Max(p => p.Number) + 1;
            }

            packages.Add(package);

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

        public async Task<bool> DeletePackage(PipePackage package)
        {
            if (package == null)
                throw new ArgumentNullException(nameof(package));
            PipePackage? searchPackage = packages.Find(p => p.Number == package.Number);
            if (searchPackage == null)
                throw new ArgumentException(nameof(package));
            packages.Remove(searchPackage);
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

        public async Task<List<PipePackage>> GetPackages()
        {
            try
            {
                await Task.Run(() => ReadFile());
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ошибка {ex.Message} чтения файла {path}");
            }

            return packages;
        }

        public async Task<bool> UpdatePackage(PipePackage package)
        {
            if (package == null)
                throw new ArgumentNullException(nameof(package));
            PipePackage? searchPackage = packages.Find(p => p.Number == package.Number);
            if (searchPackage == null)
                throw new ArgumentException(nameof(package));
            int num = packages.IndexOf(searchPackage);
            packages[num] = package;
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
