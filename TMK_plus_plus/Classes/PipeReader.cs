using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMK_plus_plus.Interfaces;

namespace TMK_plus_plus.Classes
{
    public class PipeReader : IPipeRepo
    {
        private readonly List<Pipe> pipes;

        public PipeReader()
        {
            pipes = new List<Pipe>()
            {
                new Pipe(){ Number = 1, IsOk = true, SteelGrade = "ст2сп", Lenght = 4, Radius = 20, Weight = 50},
                new Pipe(){ Number = 2, IsOk = true, SteelGrade = "ст4сп", Lenght = 3, Radius = 15, Weight = 20},
                new Pipe(){ Number = 3, IsOk = true, SteelGrade = "ст2сп", Lenght = 5, Radius = 40, Weight = 70},
            };
        }

        public Task<bool> AddPipe(Pipe pipe)
        {
            if (pipe == null)
                throw new ArgumentNullException(nameof(pipe));
            if (pipe.Number != 0)
                throw new ArgumentException(nameof(pipe));

            pipe.Number = pipes.Count == 0 ? 1 : pipes.Max(p => p.Number) + 1;
            pipes.Add(pipe);
            return Task.FromResult(true);

        }

        public Task<bool> DeletePipe(Pipe pipe)
        {
            if (pipe == null)
                throw new ArgumentNullException(nameof(pipe));
            Pipe? searchPipe = pipes.Find(p => p.Number == pipe.Number);
            if (searchPipe == null)
                throw new ArgumentException(nameof(pipe));
            pipes.Remove(pipe);
            return Task.FromResult(true);
        }

        public Task<List<Pipe>> GetPipes()
        {
            return Task.FromResult(pipes);
        }

        public Task<bool> UpdatePipe(Pipe pipe)
        {
            if (pipe == null)
                throw new ArgumentNullException(nameof(pipe));
            Pipe? searchPipe = pipes.Find(p => p.Number == pipe.Number);
            if (searchPipe == null)
                throw new ArgumentException(nameof(pipe));
            int num = pipes.IndexOf(searchPipe);
            pipes[num] = pipe;
            return Task.FromResult(true);
        }
    }
}
